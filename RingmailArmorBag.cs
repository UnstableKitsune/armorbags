using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class RingmailArmorBag : Bag
	{
		public override bool IsArtifact { get { return true; } }
		public override string DefaultName
		{
			get { return "Ringmail Armor Bag"; }
		}

		[Constructable]
		public RingmailArmorBag()
		{
            Hue = 0x0;

			DropItem( new RingmailLegs() );
            DropItem( new RingmailChest() );
			DropItem( new RingmailArms() );
			DropItem( new RingmailGloves() );
		}
		
		public RingmailArmorBag( Serial serial ) : base( serial )
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
