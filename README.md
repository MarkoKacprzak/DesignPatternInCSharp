# DesignPatternInCSharp
Design Pattern In C#:
## Behavioral (Wzorce zachowania)
Zajmują się komunikacją pomiędzy obiektami. Głównie występują w algorytmach i w skomplikowanych systemach odpowiedzialności pomiędzy obiektami.
* Chain of Responsibility
* Command
* Interpreter
* Iterator
* Mediator
* Memento
* Observer
* State
* Strategy
* Template Method
* Visitor
## Wzorzec ma na celu:
* Chain of Responsibility

Umożliwiać przekazywanie żądania na coraz wyższe poziomy aż do znalezienia obiektu, który je obsłuży
* Command

Hermetyzacja wywołania metody w obiekcie
* Interpreter

Dystrybuować operacje w taki sposób, że każda implementacja odnosi się do innego typu kompozycji
* Iterator

Udostępniać sekwencyjnego sposobu dostępu do elementów kolekcji
* Mediator

Skupić odpowiedzialność w jednej klasie, nadzorującej interakcję innych obiektów
* Memento

Zrekonstruować obiekt na podstawie starszej jego wersji, zawierającej wyłącznie stan wewnętrzny
* Observer

Oddzielić obiekt od znajomości obiektów od niego zależnych
* State

Dystrybuować operacje w taki sposób, że każda klasa reprezentuje różny stan
* Strategy

Hermetyzować operacje, powodując stworzenie zmiennych implementacji
* Template Method

Zaimplementować (w postaci metody) kilka kroków wykonania algorytmu, aby klasy podrzędne mogły je ponownie zdefiniować.
* Visitor

Umożliwienie zdefiniowanie nowej operacji dla hierarchii bez konieczności zmiany klas zawartych w tej hierarchi
## Wzorce zachowania można podzielić na grupy:
### Wzorce operacji
* Command
* Interpreter
* State
* Strategy
* Template Method
### Wzorce rozszerzeń
* Iterator
* Visitor
### Wzorce odpowiedzialności
* Chain of Responsibility
* Mediator
* Observer
### Wzorce konstrukcyjne
* Memento
## Diagramy:
<b>Chain of Responsibility:</b>
<br>
<img src="ChainOfResponsibility.png"><br>
<b>Command:</b>
<br>
<img src="Interpreter.png"><br>
<b>Interpreter:</b>
<br>
<img src="Interpreter.png"><br>
<b>Iterator:</b>
<br>
<img src="Iterator.png"><br>
<b>Mediator:</b>
<br>
<img src="Mediator.png"><br>
<b>Memento:</b>
<br>
<img src="Memento.png"><br>
<b>Observer:</b>
<br>
<img src="Observer.png"><br>
<b>State:</b>
<br>
<img src="State.png"><br>
<b>Strategy:</b>
<br>
<img src="Strategy.png"><br>
<b>Template Method:</b>
<br>
<img src="TemplateMethod.png"><br>
<b>Visitor:</b>
<br>
<img src="Visitor.png"><br>
