using System.ServiceModel;
using System.Windows.Forms;
using DSNInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Numerics;
using System.Threading;
using System.Data;

namespace DSNInterfaces
{
    [ServiceContract(SessionMode = SessionMode.Required, CallbackContract = typeof(ICallbackService))]
    public interface IDSNService
    {
        [OperationContract(IsOneWay = true)]
        void Connect();

        [OperationContract(IsOneWay = true)]
        void SendMessage(BindingList<SpaceCraft> message);
    }
}