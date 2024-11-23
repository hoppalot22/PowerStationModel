using System.Security.Cryptography;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace PowerStationModel;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    public SteamCircuit MySteamCircuit;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here
        MySteamCircuit = new SteamCircuit("Circuit 1");
        Pump FeedPump = new(1, 5f);
        Superheater Superheater1 = new("SH1", 5f);
        Turbine HPTurbine = new("HP Turbine", 580f);        
        Superheater Superheater2 = new("SH2", 5f);
        Turbine IPTurbine = new("IP Turbine", 580f);
        Turbine LPTurbine = new("LP Turbine", 580f);
        Condenser myCondensor = new();

        Pipe FeedwaterLine = new(150f, 25f);
        Pipe MainSteamLine = new(150f, 25f);
        Pipe ColdReheatine = new(150f, 25f);
        Pipe HotReheatLine = new(150f, 25f);
        Pipe CrossOverLine = new(150f, 25f);
        Pipe CondensateLine = new(150f, 25f);

        MySteamCircuit.Add(FeedPump);
        MySteamCircuit.Add(Superheater1);
        MySteamCircuit.Add(HPTurbine);        
        MySteamCircuit.Add(Superheater2);
        MySteamCircuit.Add(IPTurbine);
        MySteamCircuit.Add(LPTurbine);
        MySteamCircuit.Add(myCondensor);
        MySteamCircuit.Add(FeedwaterLine);
        MySteamCircuit.Add(MainSteamLine);        
        MySteamCircuit.Add(ColdReheatine);
        MySteamCircuit.Add(HotReheatLine);
        MySteamCircuit.Add(CrossOverLine);
        MySteamCircuit.Add(CondensateLine);

        FeedPump.Connect(FeedwaterLine);
        FeedwaterLine.Connect(Superheater1);
        Superheater1.Connect(MainSteamLine);
        MainSteamLine.Connect(HPTurbine);
        HPTurbine.Connect(ColdReheatine);
        ColdReheatine.Connect(Superheater2);
        Superheater2.Connect(HotReheatLine);
        HotReheatLine.Connect(IPTurbine);
        IPTurbine.Connect(CrossOverLine);
        CrossOverLine.Connect(LPTurbine);
        LPTurbine.Connect(myCondensor);
        myCondensor.Connect(CondensateLine);
        CondensateLine.Connect(FeedPump);
  
        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        //MySteamCircuit.Update();

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // TODO: Add your drawing code here

        base.Draw(gameTime);
    }
}
