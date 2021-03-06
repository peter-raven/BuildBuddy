﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentBuilders.Core
{
    /// <summary>
    /// Very simple builder containing a fixed instance that will be returned on Create.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ObjectContainer<T> : IBuilder<T>
    {
        public T Value { get; set; }

        public ObjectContainer(T obj)
        {
            Value = obj;
        }
        
        public T1 BuildUsing<T1>() where T1 : IBuilder
        {
            throw new NotImplementedException();
        }

        public T Create(int seed = 0)
        {
            return Value;
        }

        object IBuilder.Create(int seed)
        {
            return Create(seed);
        }

        public BuilderFactoryConvention BuilderFactoryConvention { get; set; }
        public List<Action> Setups { get; private set; }
    }
}
