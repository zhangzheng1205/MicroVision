﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;

namespace MicroVision.Core.Events
{

    /// <summary>
    /// request to update the com list in IParameterService
    /// </summary>
    public class ComListUpdateRequestedEvent : PubSubEvent {}


    /// <summary>
    /// event for COM connected successfully
    /// </summary>
    public class ComConnectedEvent: PubSubEvent {}

    /// <summary>
    /// request to connect to the target serial port
    /// </summary>
    public class ComConnectionRequestedEvent: PubSubEvent<string> {}

    /// <summary>
    /// event for COM being disconnected. The argument represents the disconnection is intentional  (true) or accidental (false)
    /// </summary>
    public class ComDisconnectedEvent: PubSubEvent<bool> { }

    /// <summary>
    /// request to disconnect the serial port
    /// </summary>
    public class ComDisconnectionRequestedEvent: PubSubEvent { }

    /// <summary>
    /// event for error raise in COM communication
    /// </summary>
    public class ComErrorOccuredEvent: PubSubEvent<string> { }

    /// <summary>
    /// 
    /// </summary>
    public class ComCommandDispatchedEvent: PubSubEvent { }


}
