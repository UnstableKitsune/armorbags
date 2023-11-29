using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class MaleLeatherArmorBag : Bag
	{
		public override bool IsArtifact { get { return true; } }
		public override string DefaultName
		{
			get { return "Male Leather Armor Bag"; }
		}

		[Constructable]
		public MaleLeatherArmorBag()
		{
            Hue = 0x0;

			DropItem( new LeatherCap() );
            DropItem( new LeatherChest() );
			DropItem( new LeatherArms() );
			DropItem( new LeatherGloves() );
			DropItem( new LeatherGorget() );
			DropItem( new LeatherLegs() );
		}
		
		public MaleLeatherArmorBag( Serial serial ) : base( serial )
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
