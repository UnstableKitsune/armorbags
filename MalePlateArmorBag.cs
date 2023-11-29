using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class MalePlateArmorBag : Bag
	{
		public override bool IsArtifact { get { return true; } }
		public override string DefaultName
		{
			get { return "Male Plate Armor Bag"; }
		}

		[Constructable]
		public MalePlateArmorBag()
		{
            Hue = 0x0;

			DropItem( new PlateHelm() );
            DropItem( new PlateChest() );
			DropItem( new PlateArms() );
			DropItem( new PlateGloves() );
			DropItem( new PlateGorget() );
			DropItem( new PlateLegs() );
		}
		
		public MalePlateArmorBag( Serial serial ) : base( serial )
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
