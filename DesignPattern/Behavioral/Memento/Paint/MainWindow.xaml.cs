using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Ink;
using System.Windows.Input;

namespace DesignPattern.Behavioral.Memento.Paint
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Stack<IMemento> states = new Stack<IMemento>();

        public MainWindow()
        {
            InitializeComponent();
            CommandBindings.Add(
                new CommandBinding(ApplicationCommands.Undo,
                                   OnExecutedCommands));
            InkCanvasWithUndo1.MouseUp += InkCanvasWithUndo1_MouseUp;

            // initialize with empty state
            StoreState();
        }

        private void StoreState()
        {
            // Save state to memento
            var memento = InkCanvasWithUndo1.CreateMemento();
            states.Push(memento);
            label1.Content = states.Count;
        }

        private void InkCanvasWithUndo1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            StoreState();
        }

        private void OnExecutedCommands(object sender, ExecutedRoutedEventArgs e)
        {
            var myWindow = (MainWindow) sender;
            if (e.Command == ApplicationCommands.Undo)
            {
                myWindow.Undo(sender, e);
            }
        }

        /// <summary>
        /// Undo the last edit.
        /// </summary>
        private void Undo(object sender, RoutedEventArgs e)
        {
            if (states.Count > 1)
            {
                // discard current state
                states.Pop();
                var lastState = states.Peek();
                InkCanvasWithUndo1.SetMemento(lastState);
            }
            label1.Content = states.Count;
        }
    }

    public class InkCanvasWithUndo : InkCanvas
    {
        public IMemento CreateMemento()
        {
            Stroke[] copy = Strokes.ToArray();
            return new InkCanvasMemento() {State = copy};
        }

        public void SetMemento(IMemento memento)
        {
            Strokes = new StrokeCollection((Stroke[]) memento.State);
        }

        public class InkCanvasMemento : IMemento
        {
            public object State { get; set; }
        }
    }

    public interface IMemento
    {
        object State { get; set; }
    }
}