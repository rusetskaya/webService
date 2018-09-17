using System.Runtime.Serialization;

namespace Gadgets.WcfService.Contracts
{
    [DataContract(Name = "ResponseOfType{0}")]
    public class Response<T>
    {
        private T _result = default(T);
        [DataMember]
        public T Result
        {
            get { return this._result; }
            set { this._result = value; }
        }

        private string _message = "";
        [DataMember]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        private string _method = "";
        [DataMember]
        public string Method
        {
            get { return this._method; }
            set { this._method = value; }
        }

        private bool _isSuccessful = false;
        [DataMember]
        public bool IsSuccessful
        {
            get { return this._isSuccessful; }
            set { this._isSuccessful = value; }
        }

        public Response(string method)
        {
            this._isSuccessful = false;
            this._message = "";
            this._method = method;
            this._result = default(T);
        }
    }
}