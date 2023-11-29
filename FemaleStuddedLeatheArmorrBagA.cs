using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class FemaleStuddedLeatherArmorBagA : Bag
	{
		public override bool IsArtifact { get { return true; } }
		public override string DefaultName
		{
			get { return "Female Studded Leather Armor Bag A"; }
		}

		[Constructable]
		public FemaleStuddedLeatherArmorBagA()
		{
            Hue = 0x0;

            DropItem( new FemaleStuddedChest() );
			DropItem( new StuddedArms() );
			DropItem( new StuddedGloves() );
			DropItem( new StuddedGorget() );
			DropItem( new StuddedLegs() );
		}
		
		public FemaleStuddedLeatherArmorBagA( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}
