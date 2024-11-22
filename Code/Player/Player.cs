using System;
using Microsoft.Xna.Framework;
using ThanaNita.MonoGameTnt;

namespace ProjectCP215
{
    public class Player : SpriteActor
    {
        AnimationStates states;

        public Player()
        {
            var size = new Vector2(32, 48);
            var texture = TextureCache.Get("resources/images/spriteSheets/mc.png");

            Origin = new Vector2(8, 8);
            Scale = new Vector2(2, 2);

            var region2d = RegionCutter.Cut(texture, size);
            var selector = new RegionSelector(region2d);
            var stay = new Animation(this, 0.5f, selector.Select1by1(0, 0));
            var left = new Animation(this, 0.5f, selector.Select(start: 4, count: 4));
            var right = new Animation(this, 0.5f, selector.Select(start: 8, count: 4));
            var up = new Animation(this, 0.5f, selector.Select(start: 12, count: 4));
            var down = new Animation(this, 0.5f, selector.Select(start: 0, count: 4));

            states = new AnimationStates([stay, left, right, up, down]);
            AddAction(states);


        }


        public override void Act(float deltaTime)
        {
            base.Act(deltaTime);

            var direction = DirectionKey.Normalized;


            if (direction.Y > 0)
            {
                states.Animate(4);
            }
            else if (direction.Y < 0)
            {
                states.Animate(3);
            }
            else if (direction.X > 0)
            {
                states.Animate(2);
            }
            else if (direction.X < 0)
            {
                states.Animate(1);
            }
            else
            {
                states.Animate(0);
            }
        }

    }
}
