﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using HERE.FlexiblePolyline;

namespace Outline
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            API_Helpers.API_Initializer.Initialize();
            API_Helpers.RouteAPIcallPolyline polylineRoute = new API_Helpers.RouteAPIcallPolyline();
            string PolylineRoutingApiCallResponse = await polylineRoute.GetRoute("wz6T_zibtMtTDYPDzVp9ZRiq7q7N1KPR4g7AL3s5BTU", "car", "52.5308,13.3847", "52.5323,13.3789");
            Trace.WriteLine("main: " + PolylineRoutingApiCallResponse);
            API_Helpers.RouteAPI.Polyline.ExtractPolylineObjectFromJson polylineExtractor = new API_Helpers.RouteAPI.Polyline.ExtractPolylineObjectFromJson(PolylineRoutingApiCallResponse);
            string polylineEncodedString = polylineExtractor.GetPolylineEncodedString();
            Trace.WriteLine("Polyline encoded string: " + polylineEncodedString);
            List<LatLngZ>coordinates = PolylineEncoderDecoder.Decode(polylineEncodedString);
            foreach(LatLngZ coordinate in coordinates)
            {
                Trace.WriteLine("Lat: " + coordinate.Lat + " Long: " + coordinate.Lng + " Z: " + coordinate.Z);
            }
        }
    }
}
