﻿using System;
using DddWorkshops.Common.Guard;
using DddWorkshops.Common.ModelFramework;

namespace DddWorkshops.Model.Meeting.Entities.Material
{
    internal class Material : Entity
    {
        private Material(string name, string url, MaterialType materialType)
        {
            Name = name;
            Url = url;
            MaterialType = materialType;
        }

        public static Material New(string name, string url, MaterialType materialType)
        {
            Guard.With<ArgumentException>()
                .Against(
                    string.IsNullOrWhiteSpace(name),
                    $"{nameof(name)} cannot be null, empty or whitespace!",
                    nameof(name));

            Guard.With<ArgumentException>()
                .Against(
                    string.IsNullOrWhiteSpace(url),
                    $"{nameof(url)} cannot be null, empty or whitespace!",
                    nameof(url));

            return new Material(name, url, materialType);
        }



        public string Name { get; private set; }

        public string Url { get; private set; }

        public MaterialType MaterialType { get; private set; }
    }
}