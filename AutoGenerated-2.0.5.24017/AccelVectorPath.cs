public class AccelVectorPath : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x30; // 48

	public AccelVectorPath(ProcessMemory memory, int address)
		: base(memory, address) { }

	public InterpolationPathHeader x00 { get { return Field<InterpolationPathHeader>(0x00); } }
	public int x20_Count { get { return Field<int>(0x20); } }
	public AccelVectorNode[] x24_PtrArray { get { return Dereference<AccelVectorNode>(0x24, x20_Count); } }
	public SerializeData x28 { get { return Field<SerializeData>(0x28); } }
}