using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Diagnostics;
using static mouse.Game1;

namespace mouse
{
    public class Game1 : Game
    {
        Texture2D felix_textura;
        Vector2 felix_posicion;
        float felix_velocidad;

        Texture2D palo_textura;
        Vector2 palo_posicion;
        float palo_velocidad;

        Texture2D magia_textura;
        List<Magia> proyectiles;
        float magia_velocidad;

        MouseState estadoRaton;
        bool disparoRealizado = false;

        private GraphicsDeviceManager _administradorGraficos;
        private SpriteBatch _spriteBatch;

        public class Magia
        {
            public Vector2 Posicion { get; set; } //"set" permite que otro codigo actualice la variable
            public Vector2 Direccion { get; set; }
            public float Velocidad { get; set; }

            public Magia(Vector2 posicion, Vector2 direccion, float velocidad)
            {
                Posicion = posicion;
                Direccion = direccion;
                Velocidad = velocidad;
            }

            public void Actualizar(GameTime gameTime)
            {
                Posicion += Direccion * Velocidad * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }
        }

        public class palo
        {
            public Vector2 Posicion { get; set; } //"set" permite que otro codigo actualice la variable
            public Vector2 Direccion { get; set; }
            public float Velocidad { get; set; }



            public palo(Vector2 posicion, Vector2 direccion, float velocidad)
            {
                Posicion = posicion;
                Direccion = direccion;
                Velocidad = velocidad;
            }

            public void Actualizar(GameTime gameTime, Vector2 objetivo)
            {
     
                Vector2 direccion = objetivo - Posicion;
                if (direccion != Vector2.Zero)
                    direccion.Normalize();

       
                Posicion += Direccion * Velocidad * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }
        }
        public Game1()
        {
            _administradorGraficos = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            proyectiles = new List<Magia>();
        }

        protected override void Initialize()
        {
            felix_velocidad = 200f;
            magia_velocidad = 300f;
            palo_velocidad = 150f;

            felix_posicion = new Vector2(100, 100); // Inicializar la posición de felix

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            felix_textura = Content.Load<Texture2D>("Skeletuschiquito");
            magia_textura = Content.Load<Texture2D>("magia");
            palo_textura = Content.Load<Texture2D>("enemigo");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            var tecla = Keyboard.GetState();

            if (tecla.IsKeyDown(Keys.W))
            {
                felix_posicion.Y -= felix_velocidad * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }

            if (tecla.IsKeyDown(Keys.S))
            {
                felix_posicion.Y += felix_velocidad * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }

            if (tecla.IsKeyDown(Keys.A))
            {
                felix_posicion.X -= felix_velocidad * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }

            if (tecla.IsKeyDown(Keys.D))
            {
                felix_posicion.X += felix_velocidad * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }

            estadoRaton = Mouse.GetState();
            if (estadoRaton.LeftButton == ButtonState.Pressed && !disparoRealizado)
            {
                Vector2 direccion = new Vector2(estadoRaton.X, estadoRaton.Y) - felix_posicion;
                direccion.Normalize();

                Magia nuevoProyectil = new Magia(felix_posicion, direccion, magia_velocidad);
                proyectiles.Add(nuevoProyectil);
                disparoRealizado = true;
            }

            if (estadoRaton.LeftButton == ButtonState.Released)
            {
                disparoRealizado = false;
            }

            foreach (Magia proyectil in proyectiles)
            {
                proyectil.Actualizar(gameTime);
            }

           
            
            palo.Actualizar(gameTime, felix_posicion);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            _spriteBatch.Draw(felix_textura, felix_posicion, Color.White);
            _spriteBatch.Draw(palo_textura, palo_posicion, Color.White);

            foreach (Magia proyectil in proyectiles)
            {
                _spriteBatch.Draw(magia_textura, proyectil.Posicion, Color.White);
            }
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}