﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSub
{
    static public class PubSubExtensions
    {
        static private readonly Hub hub = new Hub();

        static public void Publish<T>( this object obj )
        {
            hub.Publish( obj, default( T ) );
        }

        static public void Publish<T>( this object obj, T data )
        {
            hub.Publish( obj, data );
        }

        static public void Subscribe<T>( this object obj, Action<T> handler )
        {
            hub.Subscribe( obj, handler );
        }

        static public void Unsubscribe<T>( this object obj )
        {
            hub.Unsubscribe( obj, (Action<T>) null );
        }

        static public void Unsubscribe<T>( this object obj, Action<T> handler )
        {
            hub.Unsubscribe( obj, handler );
        }
    }
}
