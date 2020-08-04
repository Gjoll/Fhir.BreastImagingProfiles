﻿using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRadLibCS
{
    public abstract class ComponentSimpleItem<T> : IComponentItem<T>
        where T : class
    {
        T value;
        public T Get() => this.value;
        public void Set(T value) => this.value = value;

        public abstract void Read<F>(BreastRadiologyDocument doc, F resource)
            where F : DomainResource;
        public abstract void Write(BreastRadiologyDocument doc);
        public abstract void Validate(StringBuilder sb);
    }

    public abstract class ComponentSimpleItem<S, T, U> : IComponentItem<S, T, U>
        where S : class
        where T : class, S
        where U : class, S
    {
        S value;

        public S Get() => this.value;
        public void Set(T value) => this.value = value;
        public void Set(U value) => this.value = value;

        public abstract void Read<F>(BreastRadiologyDocument doc, F resource)
            where F : DomainResource;
        public abstract void Write(BreastRadiologyDocument doc);
        public abstract void Validate(StringBuilder sb);
    }

    public abstract class ComponentSimpleCollection<T> : IComponentCollection<T>
        where T : class
    {
        protected List<T> items = new List<T>();
        public void Append(T item) => items.Add(item);
        public void Clear() => items.Clear();
        public Int32 Count() => items.Count;
        public IEnumerable<T> Items() => items;

        public abstract void Read<F>(BreastRadiologyDocument doc, F resource)
            where F : DomainResource;
        public abstract void Write(BreastRadiologyDocument doc);
        public abstract void Validate(StringBuilder sb);
    }
}
