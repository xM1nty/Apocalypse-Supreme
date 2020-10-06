using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ApocalypseSupreme.NPCs.Slimes
{

    class RadioactiveSlime : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("RadioActive Slime");
            Main.npcFrameCount[npc.type] = 2;
        }

        public override void SetDefaults()
        {
            npc.width = 38;
            npc.height = 30;
            npc.aiStyle = NPCID.BlueSlime;
            npc.defense = 1;
            npc.damage = 8;
            npc.lifeMax = 12;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 25f;
            animationType = NPCID.BlueSlime;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldDaySlime.Chance * 0.3f;
        }
    }
}
