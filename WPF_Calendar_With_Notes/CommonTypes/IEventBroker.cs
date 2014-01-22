﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPF_Calendar_With_Notes.CommonTypes
{
    public enum EventType
    {
        LanguageChanged
    }

    public interface IListener
    {
        void NotifyMe(EventType type, object data);
    }


    public interface IEventBroker
    {
        void RegisterFor(EventType type, IListener listener);
        void UnregisterFrom(EventType type, IListener listener);
        void UnregisterFromAll(IListener listener);
        void FireEvent(EventType type, object data);
    }
}