using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class FemalePlateArmorBag : Bag
	{
		public override bool IsArtifact { get { return true; } }
		public override string DefaultName
		{
			get { return "Female Plate Armor Bag"; }
		}

		[Constructable]
		public FemalePlateArmorBag()
		{
            Hue = 0x0;

			DropItem( new PlateHelm() );
            DropItem( new FemalePlateChest() );
			DropItem( new PlateArms() );
			DropItem( new PlateGloves() );
			DropItem( new PlateGorget() );
			DropItem( new PlateLegs() );
		}
		
		public FemalePlateArmorBag( Serial serial ) : base( serial )
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
