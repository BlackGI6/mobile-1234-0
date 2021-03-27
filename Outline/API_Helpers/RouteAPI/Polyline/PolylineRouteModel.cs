using System;
using System.Collections.Generic;
using System.Text;

namespace Outline.API_Helpers.RouteAPI
{
    class section
    {
        struct arrival
        {
            struct place
            {
                struct location
                {
                    string lat;
                    string lng;
                }
                string type;
            }
            string time;
        }
        struct departure
        {
            struct place
            {
                struct location
                {
                    string lat;
                    string lng;
                }
                string type;
            }
            string time;
        }
        string id;
        string polyline;
        struct transport
        {
            string mode;
        }
        string type;
    }
    class route
    {
        string id;
        section[] sections;
    }
    public class PolylineRouteModel //Route Object ( for polyline )
    {
        route[] routes;
    }
}
