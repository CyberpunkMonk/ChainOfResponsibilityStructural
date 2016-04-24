using System;

namespace CORStructural {
    class ConcreteHandler3:Handler {
        public override void HandleRequest(Int32 request) {
            if(request>=20&&request<30)
                Console.WriteLine($"{this.GetType().Name} handled request {request}.");
            else if(successor!=null)
                successor.HandleRequest(request);
        }
    }
}