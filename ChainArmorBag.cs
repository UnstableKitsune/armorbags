using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class ChainArmorBag : Bag
	{
		public override bool IsArtifact { get { return true; } }
		public override string DefaultName
		{
			get { return "Chain Armor Bag"; }
		}

		[Constructable]
		public ChainArmorBag()
		{
            Hue = 0x0;

            DropItem( new ChainCoif() );
			DropItem( new ChainChest() );
			DropItem( new ChainLegs() );
		}
		
		public ChainArmorBag( Serial serial ) : base( serial )
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
