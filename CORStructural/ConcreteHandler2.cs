﻿using System;

namespace CORStructural {
    class ConcreteHandler2:Handler {
        public override void HandleRequest(Int32 request) {
            if(request>=10&&request<20)
                Console.WriteLine($"{this.GetType().Name} handled request {request}.");
            else if(successor!=null)
                successor.HandleRequest(request);
        }
    }
}