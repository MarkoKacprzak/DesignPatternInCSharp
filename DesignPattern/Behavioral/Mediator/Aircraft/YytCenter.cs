using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Behavioral.Mediator.Aircraft
{
    public class YytCenter : IAirTrafficControl
    {
        private readonly IList<Aircraft> _aircraftUnderGuidance = new List<Aircraft>();

        public void ReceiveAircraftLocation(Aircraft reportingAircraft)
        {
            foreach (var currentAircraftUnderGuidance in _aircraftUnderGuidance.
                Where(x => x != reportingAircraft))
            {
                if (Math.Abs(currentAircraftUnderGuidance.Altitude - reportingAircraft.Altitude) < 1000)
                {
                    currentAircraftUnderGuidance.WarnOfAirspaceIntrusionBy(reportingAircraft);
                    reportingAircraft.Climb(1000);
                    //communicate to the class
                }
            }
        }

        public void RegisterAircraftUnderGuidance(Aircraft aircraft)
        {
            if (!_aircraftUnderGuidance.Contains(aircraft))
            {
                _aircraftUnderGuidance.Add(aircraft);
            }
        }
    }
}