using System;

namespace Cosmos.IL2CPU.X86.IL
{
	[Cosmos.IL2CPU.OpCode(ILOpCode.Code.Conv_Ovf_U1)]
	public class Conv_Ovf_U1: ILOp
	{
		public Conv_Ovf_U1(Cosmos.IL2CPU.Assembler aAsmblr):base(aAsmblr)
		{
		}

    public override void Execute(uint aMethodUID, ILOpCode aOpCode) {
      //TODO: Implement this Op
    }

    
		// using System;
		// using System.IO;
		// 
		// 
		// using CPU = Indy.IL2CPU.Assembler.X86;
		// 
		// namespace Indy.IL2CPU.IL.X86 {
		// 	[OpCode(OpCodeEnum.Conv_Ovf_U1)]
		// 	public class Conv_Ovf_U1: Op {
		//         private string mNextLabel;
		// 	    private string mCurLabel;
		// 	    private uint mCurOffset;
		// 	    private MethodInformation mMethodInformation;
		// 		public Conv_Ovf_U1(ILReader aReader, MethodInformation aMethodInfo)
		// 			: base(aReader, aMethodInfo) {
		//              mMethodInformation = aMethodInfo;
		// 		    mCurOffset = aReader.Position;
		// 		    mCurLabel = IL.Op.GetInstructionLabel(aReader);
		//             mNextLabel = IL.Op.GetInstructionLabel(aReader.NextPosition);
		// 		}
		// 		public override void DoAssemble() {
		//             EmitNotImplementedException(Assembler, GetServiceProvider(), "Conv_Ovf_U1: This has not been implemented at all yet!", mCurLabel, mMethodInformation, mCurOffset, mNextLabel);
		// 		}
		// 	}
		// }
		
	}
}
