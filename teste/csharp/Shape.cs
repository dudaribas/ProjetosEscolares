    using System;

    namespace csharp
    {
        public class Shape
        {
            // A few example members
            private string poli;
            public string Poli
            {
                get { return poli; }
                set { poli = value; }
            }
            
            public Shape(string shapepoli){
                this.poli = shapepoli;
            }

            // Virtual method
            public virtual void Desenhar()
            {}
    }
}  
