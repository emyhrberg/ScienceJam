using Terraria.ModLoader;

namespace CotlimsCoolMod.Backgrounds
{
    public class DaylandSurfaceBackgroundStyle : ModSurfaceBackgroundStyle
    {
        // Use this to keep far Backgrounds like the mountains.
        public override void ModifyFarFades(float[] fades, float transitionSpeed)
        {
            for (int i = 0; i < fades.Length; i++)
            {
                if (i == Slot)
                {
                    fades[i] += transitionSpeed / 8;
                    if (fades[i] > 1f)
                    {
                        fades[i] = 1f;
                    }
                }
                else
                {
                    fades[i] -= transitionSpeed / 8;
                    if (fades[i] < 0f)
                    {
                        fades[i] = 0f;
                    }
                }
            }
        }

        public override int ChooseFarTexture()
        {
            return BackgroundTextureLoader.GetBackgroundSlot(Mod, "Assets/Textures/Backgrounds/DaylandBiomeSurfaceFar");
        }

        private static int SurfaceFrameCounter;
        private static int SurfaceFrame;
        public override int ChooseMiddleTexture()
        {
            if (++SurfaceFrameCounter > 12)
            {
                SurfaceFrame = (SurfaceFrame + 1) % 4;
                SurfaceFrameCounter = 0;
            }
            switch (0)
            {
                case 0:
                    return BackgroundTextureLoader.GetBackgroundSlot(Mod, "Assets/Textures/Backgrounds/DaylandBiomeSurfaceMid0");
                case 1:
                    return BackgroundTextureLoader.GetBackgroundSlot(Mod, "Assets/Textures/Backgrounds/DaylandBiomeSurfaceMid1");
                case 2:
                    return BackgroundTextureLoader.GetBackgroundSlot(Mod, "Assets/Textures/Backgrounds/DaylandBiomeSurfaceMid2");
                case 3:
                    return BackgroundTextureLoader.GetBackgroundSlot(Mod, "Assets/Textures/Backgrounds/DaylandBiomeSurfaceMid3"); // You can use the full path version of GetBackgroundSlot too
                default:
                    return -1;
            }
        }

        public override int ChooseCloseTexture(ref float scale, ref double parallax, ref float a, ref float b)
        {
            return BackgroundTextureLoader.GetBackgroundSlot(Mod, "Assets/Textures/Backgrounds/DaylandBiomeSurfaceClose");
        }
    }
}