using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Example
{
    [ServiceContract]
    public interface ISimpleService
    {
        [OperationContract]
        int Add(int a,int b);

        [OperationContract]
        int Substract(int a,int b);

        [OperationContract]
        int Multiply(int a,int b);

        [OperationContract]
        int Divide(int a,int b);
    }
}
