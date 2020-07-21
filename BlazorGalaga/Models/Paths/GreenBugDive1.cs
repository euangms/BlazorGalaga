﻿using System;
using System.Collections.Generic;
using System.Drawing;
using BlazorGalaga.Interfaces;
using BlazorGalaga.Models;
using BlazorGalaga.Static;

namespace BlazorGalaganimatable.Models.Paths
{
    public class GreenBugDive1 : IDive
    {
        public List<BezierCurve> GetPaths(IAnimatable animatable, Ship ship)
        {
            List<BezierCurve> paths = new List<BezierCurve>();

            var cx = Constants.CanvasSize.Width / 2;

            var rotateclockwise = new BezierCurve()
            {
                StartPoint = animatable.Location,
                EndPoint = new PointF(animatable.Location.X + 100, animatable.Location.Y),
                ControlPoint1 = new PointF(animatable.Location.X, animatable.Location.Y - 100),
                ControlPoint2 = new PointF(animatable.Location.X + 100, animatable.Location.Y - 100)
            };
            var dive = new BezierCurve()
            {
                StartPoint = new PointF(animatable.Location.X + 100, animatable.Location.Y),
                EndPoint = new PointF(animatable.Location.X + 50, animatable.Location.Y + 100),
                ControlPoint1 = new PointF(animatable.Location.X + 100, animatable.Location.Y),
                ControlPoint2 = new PointF(animatable.Location.X + 50, animatable.Location.Y + 100),
            };
            var rotateclockwise2 = new BezierCurve()
            {
                StartPoint = new PointF(animatable.Location.X + 50, animatable.Location.Y + 100),
                EndPoint = new PointF(animatable.Location.X + 50, animatable.Location.Y + 50),
                ControlPoint1 = new PointF(animatable.Location.X, animatable.Location.Y + 200),
                ControlPoint2 = new PointF(animatable.Location.X - 100, animatable.Location.Y)
            };
            var dive2 = new BezierCurve()
            {
                StartPoint = new PointF(animatable.Location.X + 50, animatable.Location.Y + 50),
                EndPoint = new PointF(ship.Location.X, Constants.CanvasSize.Height + 50),
                ControlPoint1 = new PointF(Constants.CanvasSize.Width-100, Constants.CanvasSize.Height/2),
                ControlPoint2 = new PointF(0, Constants.CanvasSize.Height-100),
            };
            var gohome = new BezierCurve()
            {
                StartPoint = new PointF(ship.Location.X + 90, -50),
                EndPoint = (animatable as Bug).HomePoint,
                ControlPoint1 = new PointF(Constants.CanvasSize.Width, 0),
                ControlPoint2 = new PointF(0, 0)
            };

            paths.Add(rotateclockwise);
            paths.Add(dive);
            paths.Add(rotateclockwise2);
            paths.Add(dive2);
            paths.Add(gohome);

            return paths;
        }
    }
}