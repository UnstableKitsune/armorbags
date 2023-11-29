using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class MaleStuddedLeatherArmorBag : Bag
	{
		public override bool IsArtifact { get { return true; } }
		public override string DefaultName
		{
			get { return "Male Studded Leather Armor Bag"; }
		}

		[Constructable]
		public MaleStuddedLeatherArmorBag()
		{
            Hue = 0x0;

            DropItem( new StuddedChest() );
			DropItem( new StuddedArms() );
			DropItem( new StuddedGloves() );
			DropItem( new StuddedGorget() );
			DropItem( new StuddedLegs() );
		}
		
		public MaleStuddedLeatherArmorBag( Serial serial ) : base( serial )
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
