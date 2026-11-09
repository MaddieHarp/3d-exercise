using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Basic3DExercise;

public class Basic3DExampleGame : Game
{
        // The cube to draw 
    Cube cube;
        // The quad to draw
    Quad quad;
        // The triangle to draw
    Triangle triangle;
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    public Basic3DExampleGame()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        // Create the triangle
        triangle = new Triangle(this);
            // Create the cube
    cube = new Cube(this);
            // Create the quad
        quad = new Quad(this);

        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here
        triangle.Update(gameTime);
            // update the cube 
    cube.Update(gameTime);

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // TODO: Add your drawing code here
        triangle.Draw();
            // Draw the quad
        quad.Draw();

            // draw the cube
    cube.Draw();

        base.Draw(gameTime);
    }
}
