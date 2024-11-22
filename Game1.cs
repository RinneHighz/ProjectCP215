using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ThanaNita.MonoGameTnt;

using MonoGame.Extended.Tiled;
using MonoGame.Extended.Tiled.Renderers;

namespace ProjectCP215
{
    public class Game1 : Game2D
    {
        Player player;
        TextureRegion[] tiles;
        TiledMap tileMap;

        TiledMapRenderer tiledMapRenderer;
        protected override void LoadContent()
        {
            var tileSize = new Vector2(96, 96);
            BackgroundColor = Color.White;
            player = new Player() { Position = tileSize / 2 };

            // PrepareTileSet();
            // var tileArray = new int[6, 6]
            // {
            //     { 0, 1, 1, 1, 1, 2 },
            //     { 11, 12, 12, 53, 54, 13 },
            //     { 22, 23, 23, 64, 65, 24 },
            //     { 0, 1, 1, 75, 76, 2 },
            //     { 11, 12, 12, 12, 12, 13 },
            //     { 22, 23, 23, 23, 23, 24 }
            // };
            // tileMap = new TileMap(tileSize, tileArray, CreateTile);

            tileMap = Content.Load<TiledMap>("resources/tileMaps/TestMap.tmx");
            tiledMapRenderer = new TiledMapRenderer(GraphicsDevice, tileMap);

            var visual = new Actor() { Position = new Vector2(200, 200) };
            visual.Add(player);
            All.Add(visual);
        }

        // private Actor CreateTile(int tileCode)
        // {
        //     var sprite = new SpriteActor(tiles[tileCode]);
        //     sprite.Origin = sprite.RawSize / 2;
        //     sprite.Scale = new Vector2(6, 6);
        //     return sprite;
        // }

        // private void PrepareTileSet()
        // {
        //     var texture = TextureCache.Get("resources/images/tileMaps/Hills.png");
        //     var tiles2d = RegionCutter.Cut(texture, new Vector2(16, 16), countX: 11, countY: 7);
        //     tiles = RegionSelector.SelectAll(tiles2d);
        // }

        // KeyQueue keyQueue = new KeyQueue();
        // LinearMotion motion = LinearMotion.Empty();
        // private void StepJumpMovement()
        // {
        //     var keyInfo = GlobalKeyboardInfo.Value;
        //     if (!keyInfo.IsAnyKeyPressed())
        //     {
        //         return;
        //     }
        //     var key = keyInfo.GetPressedKeys()[0];
        //     var direction = DirectionKey.DirectionOf(key);
        //     if (!IsAllowMove(direction))
        //     {
        //         return;
        //     }
        //     player.Position += direction * tileMap.TileSize;

        // }

        // private bool IsAllowMove(Vector2 direction)
        // {
        //     Vector2i index = tileMap.CalcIndex(player.Position, direction);
        //     return tileMap.IsInside(index) && IsAllowTile(index);
        // }

        // private bool IsAllowTile(Vector2i index)
        // {
        //     int tileCode = tileMap.GetTileCode(index);
        //     return tileCode is not (22 or 23 or 24);
        // }


        // protected override void Update(float deltaTime)
        // {
        //     var keyInfo = GlobalKeyboardInfo.Value;
        //     keyQueue.EnqueueAll(keyInfo.GetPressedKeys());

        //     motion.Act(deltaTime);
        //     SmoothMovement();
        //     //StepJumpMovement();
        // }

        // private void SmoothMovement()
        // {
        //     if (!motion.IsFinished())
        //     {
        //         var command1 = keyQueue.PeekCommand();
        //         if (command1.IsOpposite(motion.Direction))
        //         {
        //             UnstableMoveOpposite(keyQueue.GetCommand().Direction);
        //         }
        //         return;
        //     }

        //     var command = keyQueue.GetCommand();
        //     Vector2 direction = Vector2.Zero;
        //     if (command.HasCommand())
        //     {
        //         direction = command.Direction;
        //     }
        //     else
        //     {
        //         direction = DirectionKey.Direction4;
        //         //if(DirectionKey.Direction4 == Vector2.Zero)
        //         //{
        //         //    direction = motion.Direction;
        //         //}
        //     }
        //     StableMove(direction);
        // }

       

        // private void StableMove(Vector2 direction)
        // {
        //     if (!IsAllowMove(direction))
        //     {
        //         direction = new Vector2(0, 0);
        //     }
        //     if (motion.Direction == Vector2.Zero && direction == Vector2.Zero)
        //     {
        //         return;
        //     }
        //     if (direction != motion.Direction)
        //     {
        //         motion.ToPreciseTarget();
        //     }

        //     CreateMotion(player.Position, direction);
        // }

        // private void UnstableMoveOpposite(Vector2 direction)
        // {
        //     CreateMotion(motion.TargetPosition, direction);
        // }

        // private void CreateMotion(Vector2 oldPosition, Vector2 direction)
        // {
        //     var targetPosition = tileMap.TileCenter(oldPosition, direction);
        //     motion = new LinearMotion(player, speed: 300, targetPosition, direction);
        // }
    }

}
