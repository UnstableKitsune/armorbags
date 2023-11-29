using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class BoneArmorBag : Bag
	{
		public override bool IsArtifact { get { return true; } }
		public override string DefaultName
		{
			get { return "Bone Armor Bag"; }
		}

		[Constructable]
		public BoneArmorBag()
		{
            Hue = 0x0;

            DropItem( new BoneChest() );
			DropItem( new BoneArms() );
			DropItem( new BoneGloves() );
			DropItem( new BoneHelm() );
			DropItem( new BoneLegs() );
		}
		
		public BoneArmorBag( Serial serial ) : base( serial )
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
