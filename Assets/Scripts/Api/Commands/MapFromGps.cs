/**
* Copyright (c) 2019 LG Electronics, Inc.
*
* This software contains code licensed as described in LICENSE.
*
*/

using SimpleJSON;
using UnityEngine;
using Simulator.Map;

namespace Api.Commands
{
    class MapFromGps : ICommand
    {
        public string Name { get { return "map/from_gps"; } }

        public void Execute(JSONNode args)
        {
            var map = GameObject.Find("MapOrigin")?.GetComponent<MapOrigin>();
            var api = SimulatorManager.Instance.ApiManager;

            if (map == null)
            {
                api.SendError("MapOrigin not found. Is the scene loaded?");
                return;
            }

            Vector3 position;

            if (args["latitude"] == null)
            {
                var northing = args["northing"].AsDouble;
                var easting = args["easting"].AsDouble;

                position = map.FromNorthingEasting(northing, easting);
            }
            else
            {
                var latitude = args["latitude"].AsDouble;
                var longitude = args["longitude"].AsDouble;

                double northing, easting;
                map.FromLatitudeLongitude(latitude, longitude, out northing, out easting);

                position = map.FromNorthingEasting(northing, easting);
            }

            var altitude = args["altitude"];
            if (altitude != null)
            {
                position.y = altitude.AsFloat - map.AltitudeOffset;
            }

            // TODO angle removed, needed?
            Vector3 rotation = Vector3.zero;
            //var orientation = args["orientation"];
            //if (orientation != null)
            //{
            //    rotation.y = -orientation.AsFloat - map.Angle;
            //}

            var result = new JSONObject();
            result.Add("position", position);
            result.Add("rotation", rotation);

            api.SendResult(result);
        }
    }
}
