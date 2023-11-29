using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class FemaleLeatherArmorBagB : Bag
	{
		public override bool IsArtifact { get { return true; } }
		public override string DefaultName
		{
			get { return "Female Leather Armor Bag B"; }
		}

		[Constructable]
		public FemaleLeatherArmorBagB()
		{
            Hue = 0x0;

            DropItem( new LeatherBustierArms() );
			DropItem( new LeatherArms() );
			DropItem( new LeatherGloves() );
			DropItem( new LeatherGorget() );
			DropItem( new LeatherSkirt() );
			DropItem( new LeatherCap() );
		}
		
		public FemaleLeatherArmorBagB( Serial serial ) : base( serial )
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
