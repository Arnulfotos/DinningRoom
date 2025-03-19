namespace DinningRoom
{
    public partial class Form1 : Form
    {

        // Numero total de filosofos en la simulacion
        const int NUM_FILOSOFOS = 4;

        // Arreglo de objetos que representa los palillos compartidos
        static object[] palillos = new object[NUM_FILOSOFOS];

        // Arreglo para contar cuantas veces ha comido cada filosofo
        static int[] vecesComido = new int[NUM_FILOSOFOS];

        // Contador global de comidas realizadas en la ronda actual
        static int totalComidas = 0;

        // Objeto de bloqueo para sincronizar el acceso al contador global
        static object lockComida = new object();


        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < NUM_FILOSOFOS; i++)
            {
                palillos[i] = new object();

            }
        }

        private void InitBtn_Click(object sender, EventArgs e)
        {
            while (true) // Bucle principal de ejecucion
            {
                ReiniciarComidas(); // Reinicia los contadores de comidas

                // Crear y lanzar tareas para los filosofos
                Task[] filosofos = new Task[NUM_FILOSOFOS];
                for (int i = 0; i < NUM_FILOSOFOS; i++)
                {
                    int id = i; // Guardar el id para evitar problemas en las tareas
                    filosofos[i] = Task.Run(() => ComerYPensar(id));
                }

                // Esperar hasta que todos los filosofos hayan comido al menos una vez
                while (true)
                {
                    lock (lockComida) // Bloquear el acceso a totalComidas para evitar condiciones de carrera
                    {
                        /*if (totalComidas >= NUM_FILOSOFOS) // Verifica si todos los filosofos ya comieron
                        {
                            Console.WriteLine("\nTodos los filosofos han comido al menos una vez.");
                            Console.Write("Quieres reiniciar el proceso? (s/n): ");
                            string respuesta = Console.ReadLine()?.Trim().ToLower();

                            if (respuesta == "s") // Si el usuario quiere reiniciar
                            {
                                Console.Clear(); // Limpiar la pantalla para reiniciar
                                Console.WriteLine("Reiniciando el proceso...\n");
                                Thread.Sleep(1000); // Pequeña pausa antes de reiniciar
                                break; // Salir del bucle y reiniciar el proceso
                            }
                            else // Si el usuario elige no reiniciar
                            {
                                Console.WriteLine("\nFinalizando el programa...");
                                Thread.Sleep(2000); // Pausa antes de cerrar
                                Environment.Exit(0); // Termina la ejecucion del programa
                            }
                        }*/
                    }
                    Thread.Sleep(500); // Pausa para reducir el uso de CPU
                }
            }
        }



        static void ReiniciarComidas()
        {
            lock (lockComida) // Bloquear para evitar acceso simultaneo
            {
                totalComidas = 0; // Reiniciar el contador global de comidas
                Array.Clear(vecesComido, 0, vecesComido.Length); // Resetear el conteo individual de cada filosofo
            }
        }

        // Metodo que simula el proceso de pensar y comer de cada filosofo
        static void ComerYPensar(int id)
        {
            // Identificar los palillos a la izquierda y derecha del filosofo
            int palilloIzq = id;
            int palilloDer = (id + 1) % NUM_FILOSOFOS;

            while (true)
            {
                Console.WriteLine($"Filosofo {id} esta pensando...");
                Thread.Sleep(new Random().Next(1000, 3000)); // Simular el tiempo de pensar

                // Controlar el acceso a los palillos para evitar interbloqueo
                if (id % 2 == 0) // Filosofos con id par toman primero el palillo izquierdo
                {
                    lock (palillos[palilloIzq])
                    {
                        lock (palillos[palilloDer])
                        {
                            Comer(id);
                            break; // Termina despues de comer una vez
                        }
                    }
                }
                else // Filosofos con id impar toman primero el palillo derecho
                {
                    lock (palillos[palilloDer])
                    {
                        lock (palillos[palilloIzq])
                        {
                            Comer(id);
                            break; // Termina despues de comer una vez
                        }
                    }
                }
            }
        }

        // Metodo que simula la accion de comer
        static void Comer(int id)
        {
            Console.WriteLine($"Filosofo {id} tomo ambos palillos y esta comiendo.");
            Thread.Sleep(new Random().Next(1000, 3000)); // Simular el tiempo de comer

            // Actualizar el contador de comidas de manera segura
            lock (lockComida)
            {
                vecesComido[id]++; // Registrar que este filosofo ha comido
                totalComidas++; // Incrementar el conteo global de comidas
            }

            Console.WriteLine($"Filosofo {id} termino de comer.");
        }


    }





    


    }

