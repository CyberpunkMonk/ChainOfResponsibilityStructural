using System;

namespace CORStructural {
    class ConcreteHandler1:Handler {
        public override void HandleRequest(Int32 request) {
            if(request>=0&&request<10)
                Console.WriteLine($"{this.GetType().Name} handled request {request}.");
            else if(successor!=null)
                successor.HandleRequest(request);
        }
    }
}
