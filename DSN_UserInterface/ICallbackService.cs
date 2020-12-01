using System.ServiceModel;

namespace DSNInterfaces
{
    public interface ICallbackService
    {
        [OperationContract(IsOneWay = true)]
        void SendCallbackMessage(string message);
    }
}