using System;

namespace ProjetoCarro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            vehicle carro1 = new vehicle("BMW", "X5", "Cinza Escuro", 2.0);
            vehicle carro2 = new vehicle("Honda", "Civic", "Azul", 2.0);
            vehicle carro3 = new vehicle("VW", "Novo Polo", "Preto", 1.0);
            vehicle carro4 = new vehicle("VW", "Novo Polo", "Prata", 1.0);
            vehicle carro5 = new vehicle("VW", "Novo Polo", "Prata", 1.0);
            vehicle carro6 = new vehicle("VW", "Gol", "Branco", 2.0);
            vehicle carro7 = new vehicle("Honda", "Novo Polo", "Prata", 1.0);

            carro5.info();
            //Console.WriteLine(carro3.Equals(carro5));
            Console.WriteLine(carro5.Equals(carro6));
            Console.WriteLine(carro1.getvel());
            carro1.setvel(50);
            Console.WriteLine(carro1.getvel());
        }
    }

    class vehicle : IEquatable<vehicle>
    {
        public string marca;
        public string modelo;
        public string cor;
        public double motor;
        private double vel;

        public vehicle(string marca, string modelo, string cor, double motor)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cor = cor;
            this.motor = motor;
            vel = 0;
        }

        public double getvel()
        {
            return vel;
        }

        public void setvel(double vel)
        {
            this.vel = vel;
        }

        public bool Equals(vehicle other)
        {
            return this.marca == other.marca;
        }

        public void info()
        {
            Console.WriteLine($"Marca.: {this.marca}");
            Console.WriteLine($"Modelo: {this.modelo}");
            Console.WriteLine($"Cor...: {this.cor}");
            Console.WriteLine($"Motor.: {this.motor}");
            Console.WriteLine($"Vel...: {this.vel}");
        }

        /*if (this.marca == other.marca && this.modelo == other.modelo && this.motor == other.motor)
            {
                return true;
            }
        */
    }
}
