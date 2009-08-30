﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cosmos.Assembler.X86
{
    public enum InstructionEnum
    {
        AAA,
        AAD,
        AAM,
        AAS,
        ADC,
        ADD,
        ADDPD,
        ADDPS,
        ADDSD,
        ADDSS,
        ADDSUBPD,
        ADDSUBPS,
        AESDEC,
        AESDECLAST,
        AESENC,
        AESENCLAST,
        AESIMC,
        AESKEYGENASSIST,
        AND,
        ANDNPD,
        ANDNPS,
        ANDPD,
        ANDPS,
        ARPL,
        BB0_RESET,
        BB1_RESET,
        BLENDPD,
        BLENDPS,
        BLENDVPD,
        BLENDVPS,
        BOUND,
        BSF,
        BSR,
        BSWAP,
        BT,
        BTC,
        BTR,
        BTS,
        CALL,
        CBW,
        CDQ,
        CDQE,
        CLC,
        CLD,
        CLFLUSH,
        CLGI,
        CLI,
        CLTS,
        CMC,
        CMP,
        CMPEQPD,
        CMPEQPS,
        CMPEQSD,
        CMPEQSS,
        CMPLEPD,
        CMPLEPS,
        CMPLESD,
        CMPLESS,
        CMPLTPD,
        CMPLTPS,
        CMPLTSD,
        CMPLTSS,
        CMPNEQPD,
        CMPNEQPS,
        CMPNEQSD,
        CMPNEQSS,
        CMPNLEPD,
        CMPNLEPS,
        CMPNLESD,
        CMPNLESS,
        CMPNLTPD,
        CMPNLTPS,
        CMPNLTSD,
        CMPNLTSS,
        CMPORDPD,
        CMPORDPS,
        CMPORDSD,
        CMPORDSS,
        CMPPD,
        CMPPS,
        CMPSB,
        CMPSD,
        CMPSQ,
        CMPSS,
        CMPSW,
        CMPUNORDPD,
        CMPUNORDPS,
        CMPUNORDSD,
        CMPUNORDSS,
        CMPXCHG,
        CMPXCHG16B,
        CMPXCHG486,
        CMPXCHG8B,
        COMEQPD,
        COMEQPS,
        COMEQSD,
        COMEQSS,
        COMFALSEPD,
        COMFALSEPS,
        COMFALSESD,
        COMFALSESS,
        COMISD,
        COMISS,
        COMLEPD,
        COMLEPS,
        COMLESD,
        COMLESS,
        COMLTPD,
        COMLTPS,
        COMLTSD,
        COMLTSS,
        COMNEQPD,
        COMNEQPS,
        COMNEQSD,
        COMNEQSS,
        COMNLEPD,
        COMNLEPS,
        COMNLESD,
        COMNLESS,
        COMNLTPD,
        COMNLTPS,
        COMNLTSD,
        COMNLTSS,
        COMORDPD,
        COMORDPS,
        COMORDSD,
        COMORDSS,
        COMPD,
        COMPS,
        COMSD,
        COMSS,
        COMTRUEPD,
        COMTRUEPS,
        COMTRUESD,
        COMTRUESS,
        COMUEQPD,
        COMUEQPS,
        COMUEQSD,
        COMUEQSS,
        COMULEPD,
        COMULEPS,
        COMULESD,
        COMULESS,
        COMULTPD,
        COMULTPS,
        COMULTSD,
        COMULTSS,
        COMUNEQPD,
        COMUNEQPS,
        COMUNEQSD,
        COMUNEQSS,
        COMUNLEPD,
        COMUNLEPS,
        COMUNLESD,
        COMUNLESS,
        COMUNLTPD,
        COMUNLTPS,
        COMUNLTSD,
        COMUNLTSS,
        COMUNORDPD,
        COMUNORDPS,
        COMUNORDSD,
        COMUNORDSS,
        CPUID,
        CPU_READ,
        CPU_WRITE,
        CQO,
        CRC32,
        CVTDQ2PD,
        CVTDQ2PS,
        CVTPD2DQ,
        CVTPD2PI,
        CVTPD2PS,
        CVTPH2PS,
        CVTPI2PD,
        CVTPI2PS,
        CVTPS2DQ,
        CVTPS2PD,
        CVTPS2PH,
        CVTPS2PI,
        CVTSD2SI,
        CVTSD2SS,
        CVTSI2SD,
        CVTSI2SS,
        CVTSS2SD,
        CVTSS2SI,
        CVTTPD2DQ,
        CVTTPD2PI,
        CVTTPS2DQ,
        CVTTPS2PI,
        CVTTSD2SI,
        CVTTSS2SI,
        CWD,
        CWDE,
        DAA,
        DAS,
        DB,
        DD,
        DEC,
        DIV,
        DIVPD,
        DIVPS,
        DIVSD,
        DIVSS,
        DMINT,
        DO,
        DPPD,
        DPPS,
        DQ,
        DT,
        DW,
        DY,
        EMMS,
        ENTER,
        EQU,
        EXTRACTPS,
        EXTRQ,
        F2XM1,
        FABS,
        FADD,
        FADDP,
        FBLD,
        FBSTP,
        FCHS,
        FCLEX,
        FCMOVB,
        FCMOVBE,
        FCMOVE,
        FCMOVNB,
        FCMOVNBE,
        FCMOVNE,
        FCMOVNU,
        FCMOVU,
        FCOM,
        FCOMI,
        FCOMIP,
        FCOMP,
        FCOMPP,
        FCOS,
        FDECSTP,
        FDISI,
        FDIV,
        FDIVP,
        FDIVR,
        FDIVRP,
        FEMMS,
        FENI,
        FFREE,
        FFREEP,
        FIADD,
        FICOM,
        FICOMP,
        FIDIV,
        FIDIVR,
        FILD,
        FIMUL,
        FINCSTP,
        FINIT,
        FIST,
        FISTP,
        FISTTP,
        FISUB,
        FISUBR,
        FLD,
        FLD1,
        FLDCW,
        FLDENV,
        FLDL2E,
        FLDL2T,
        FLDLG2,
        FLDLN2,
        FLDPI,
        FLDZ,
        FMADDPD,
        FMADDPS,
        FMADDSD,
        FMADDSS,
        FMSUBPD,
        FMSUBPS,
        FMSUBSD,
        FMSUBSS,
        FMUL,
        FMULP,
        FNCLEX,
        FNDISI,
        FNENI,
        FNINIT,
        FNMADDPD,
        FNMADDPS,
        FNMADDSD,
        FNMADDSS,
        FNMSUBPD,
        FNMSUBPS,
        FNMSUBSD,
        FNMSUBSS,
        FNOP,
        FNSAVE,
        FNSTCW,
        FNSTENV,
        FNSTSW,
        FPATAN,
        FPREM,
        FPREM1,
        FPTAN,
        FRCZPD,
        FRCZPS,
        FRCZSD,
        FRCZSS,
        FRNDINT,
        FRSTOR,
        FSAVE,
        FSCALE,
        FSETPM,
        FSIN,
        FSINCOS,
        FSQRT,
        FST,
        FSTCW,
        FSTENV,
        FSTP,
        FSTSW,
        FSUB,
        FSUBP,
        FSUBR,
        FSUBRP,
        FTST,
        FUCOM,
        FUCOMI,
        FUCOMIP,
        FUCOMP,
        FUCOMPP,
        FWAIT,
        FXAM,
        FXCH,
        FXRSTOR,
        FXSAVE,
        FXTRACT,
        FYL2X,
        FYL2XP1,
        GETSEC,
        HADDPD,
        HADDPS,
        HINT_NOP0,
        HINT_NOP1,
        HINT_NOP10,
        HINT_NOP11,
        HINT_NOP12,
        HINT_NOP13,
        HINT_NOP14,
        HINT_NOP15,
        HINT_NOP16,
        HINT_NOP17,
        HINT_NOP18,
        HINT_NOP19,
        HINT_NOP2,
        HINT_NOP20,
        HINT_NOP21,
        HINT_NOP22,
        HINT_NOP23,
        HINT_NOP24,
        HINT_NOP25,
        HINT_NOP26,
        HINT_NOP27,
        HINT_NOP28,
        HINT_NOP29,
        HINT_NOP3,
        HINT_NOP30,
        HINT_NOP31,
        HINT_NOP32,
        HINT_NOP33,
        HINT_NOP34,
        HINT_NOP35,
        HINT_NOP36,
        HINT_NOP37,
        HINT_NOP38,
        HINT_NOP39,
        HINT_NOP4,
        HINT_NOP40,
        HINT_NOP41,
        HINT_NOP42,
        HINT_NOP43,
        HINT_NOP44,
        HINT_NOP45,
        HINT_NOP46,
        HINT_NOP47,
        HINT_NOP48,
        HINT_NOP49,
        HINT_NOP5,
        HINT_NOP50,
        HINT_NOP51,
        HINT_NOP52,
        HINT_NOP53,
        HINT_NOP54,
        HINT_NOP55,
        HINT_NOP56,
        HINT_NOP57,
        HINT_NOP58,
        HINT_NOP59,
        HINT_NOP6,
        HINT_NOP60,
        HINT_NOP61,
        HINT_NOP62,
        HINT_NOP63,
        HINT_NOP7,
        HINT_NOP8,
        HINT_NOP9,
        HLT,
        HSUBPD,
        HSUBPS,
        IBTS,
        ICEBP,
        IDIV,
        IMUL,
        IN,
        INC,
        INCBIN,
        INSB,
        INSD,
        INSERTPS,
        INSERTQ,
        INSW,
        INT,
        INT01,
        INT03,
        INT1,
        INT3,
        INTO,
        INVD,
        INVEPT,
        INVLPG,
        INVLPGA,
        INVVPID,
        IRET,
        IRETD,
        IRETQ,
        IRETW,
        JCXZ,
        JECXZ,
        JMP,
        JMPE,
        JRCXZ,
        LAHF,
        LAR,
        LDDQU,
        LDMXCSR,
        LDS,
        LEA,
        LEAVE,
        LES,
        LFENCE,
        LFS,
        LGDT,
        LGS,
        LIDT,
        LLDT,
        LMSW,
        LOADALL,
        LOADALL286,
        LODSB,
        LODSD,
        LODSQ,
        LODSW,
        LOOP,
        LOOPE,
        LOOPNE,
        LOOPNZ,
        LOOPZ,
        LSL,
        LSS,
        LTR,
        LZCNT,
        MASKMOVDQU,
        MASKMOVQ,
        MAXPD,
        MAXPS,
        MAXSD,
        MAXSS,
        MFENCE,
        MINPD,
        MINPS,
        MINSD,
        MINSS,
        MONITOR,
        MONTMUL,
        MOV,
        MOVAPD,
        MOVAPS,
        MOVBE,
        MOVD,
        MOVDDUP,
        MOVDQ2Q,
        MOVDQA,
        MOVDQU,
        MOVHLPS,
        MOVHPD,
        MOVHPS,
        MOVLHPS,
        MOVLPD,
        MOVLPS,
        MOVMSKPD,
        MOVMSKPS,
        MOVNTDQ,
        MOVNTDQA,
        MOVNTI,
        MOVNTPD,
        MOVNTPS,
        MOVNTQ,
        MOVNTSD,
        MOVNTSS,
        MOVQ,
        MOVQ2DQ,
        MOVSB,
        MOVSD,
        MOVSHDUP,
        MOVSLDUP,
        MOVSQ,
        MOVSS,
        MOVSW,
        MOVSX,
        MOVSXD,
        MOVUPD,
        MOVUPS,
        MOVZX,
        MPSADBW,
        MUL,
        MULPD,
        MULPS,
        MULSD,
        MULSS,
        MWAIT,
        NEG,
        NOP,
        NOT,
        OR,
        ORPD,
        ORPS,
        OUT,
        OUTSB,
        OUTSD,
        OUTSW,
        PABSB,
        PABSD,
        PABSW,
        PACKSSDW,
        PACKSSWB,
        PACKUSDW,
        PACKUSWB,
        PADDB,
        PADDD,
        PADDQ,
        PADDSB,
        PADDSIW,
        PADDSW,
        PADDUSB,
        PADDUSW,
        PADDW,
        PALIGNR,
        PAND,
        PANDN,
        PAUSE,
        PAVEB,
        PAVGB,
        PAVGUSB,
        PAVGW,
        PBLENDVB,
        PBLENDW,
        PCLMULHQHQDQ,
        PCLMULHQLQDQ,
        PCLMULLQHQDQ,
        PCLMULLQLQDQ,
        PCLMULQDQ,
        PCMOV,
        PCMPEQB,
        PCMPEQD,
        PCMPEQQ,
        PCMPEQW,
        PCMPESTRI,
        PCMPESTRM,
        PCMPGTB,
        PCMPGTD,
        PCMPGTQ,
        PCMPGTW,
        PCMPISTRI,
        PCMPISTRM,
        PCOMB,
        PCOMD,
        PCOMEQB,
        PCOMEQD,
        PCOMEQQ,
        PCOMEQUB,
        PCOMEQUD,
        PCOMEQUQ,
        PCOMEQUW,
        PCOMEQW,
        PCOMFALSEB,
        PCOMFALSED,
        PCOMFALSEQ,
        PCOMFALSEUB,
        PCOMFALSEUD,
        PCOMFALSEUQ,
        PCOMFALSEUW,
        PCOMFALSEW,
        PCOMGEB,
        PCOMGED,
        PCOMGEQ,
        PCOMGEUB,
        PCOMGEUD,
        PCOMGEUQ,
        PCOMGEUW,
        PCOMGEW,
        PCOMGTB,
        PCOMGTD,
        PCOMGTQ,
        PCOMGTUB,
        PCOMGTUD,
        PCOMGTUQ,
        PCOMGTUW,
        PCOMGTW,
        PCOMLEB,
        PCOMLED,
        PCOMLEQ,
        PCOMLEUB,
        PCOMLEUD,
        PCOMLEUQ,
        PCOMLEUW,
        PCOMLEW,
        PCOMLTB,
        PCOMLTD,
        PCOMLTQ,
        PCOMLTUB,
        PCOMLTUD,
        PCOMLTUQ,
        PCOMLTUW,
        PCOMLTW,
        PCOMNEQB,
        PCOMNEQD,
        PCOMNEQQ,
        PCOMNEQUB,
        PCOMNEQUD,
        PCOMNEQUQ,
        PCOMNEQUW,
        PCOMNEQW,
        PCOMQ,
        PCOMTRUEB,
        PCOMTRUED,
        PCOMTRUEQ,
        PCOMTRUEUB,
        PCOMTRUEUD,
        PCOMTRUEUQ,
        PCOMTRUEUW,
        PCOMTRUEW,
        PCOMUB,
        PCOMUD,
        PCOMUQ,
        PCOMUW,
        PCOMW,
        PDISTIB,
        PERMPD,
        PERMPS,
        PEXTRB,
        PEXTRD,
        PEXTRQ,
        PEXTRW,
        PF2ID,
        PF2IW,
        PFACC,
        PFADD,
        PFCMPEQ,
        PFCMPGE,
        PFCMPGT,
        PFMAX,
        PFMIN,
        PFMUL,
        PFNACC,
        PFPNACC,
        PFRCP,
        PFRCPIT1,
        PFRCPIT2,
        PFRCPV,
        PFRSQIT1,
        PFRSQRT,
        PFRSQRTV,
        PFSUB,
        PFSUBR,
        PHADDBD,
        PHADDBQ,
        PHADDBW,
        PHADDD,
        PHADDDQ,
        PHADDSW,
        PHADDUBD,
        PHADDUBQ,
        PHADDUBW,
        PHADDUDQ,
        PHADDUWD,
        PHADDUWQ,
        PHADDW,
        PHADDWD,
        PHADDWQ,
        PHMINPOSUW,
        PHSUBBW,
        PHSUBD,
        PHSUBDQ,
        PHSUBSW,
        PHSUBW,
        PHSUBWD,
        PI2FD,
        PI2FW,
        PINSRB,
        PINSRD,
        PINSRQ,
        PINSRW,
        PMACHRIW,
        PMACSDD,
        PMACSDQH,
        PMACSDQL,
        PMACSSDD,
        PMACSSDQH,
        PMACSSDQL,
        PMACSSWD,
        PMACSSWW,
        PMACSWD,
        PMACSWW,
        PMADCSSWD,
        PMADCSWD,
        PMADDUBSW,
        PMADDWD,
        PMAGW,
        PMAXSB,
        PMAXSD,
        PMAXSW,
        PMAXUB,
        PMAXUD,
        PMAXUW,
        PMINSB,
        PMINSD,
        PMINSW,
        PMINUB,
        PMINUD,
        PMINUW,
        PMOVMSKB,
        PMOVSXBD,
        PMOVSXBQ,
        PMOVSXBW,
        PMOVSXDQ,
        PMOVSXWD,
        PMOVSXWQ,
        PMOVZXBD,
        PMOVZXBQ,
        PMOVZXBW,
        PMOVZXDQ,
        PMOVZXWD,
        PMOVZXWQ,
        PMULDQ,
        PMULHRIW,
        PMULHRSW,
        PMULHRWA,
        PMULHRWC,
        PMULHUW,
        PMULHW,
        PMULLD,
        PMULLW,
        PMULUDQ,
        PMVGEZB,
        PMVLZB,
        PMVNZB,
        PMVZB,
        POP,
        POPA,
        POPAD,
        POPAW,
        POPCNT,
        POPF,
        POPFD,
        POPFQ,
        POPFW,
        POR,
        PPERM,
        PREFETCH,
        PREFETCHNTA,
        PREFETCHT0,
        PREFETCHT1,
        PREFETCHT2,
        PREFETCHW,
        PROTB,
        PROTD,
        PROTQ,
        PROTW,
        PSADBW,
        PSHAB,
        PSHAD,
        PSHAQ,
        PSHAW,
        PSHLB,
        PSHLD,
        PSHLQ,
        PSHLW,
        PSHUFB,
        PSHUFD,
        PSHUFHW,
        PSHUFLW,
        PSHUFW,
        PSIGNB,
        PSIGND,
        PSIGNW,
        PSLLD,
        PSLLDQ,
        PSLLQ,
        PSLLW,
        PSRAD,
        PSRAW,
        PSRLD,
        PSRLDQ,
        PSRLQ,
        PSRLW,
        PSUBB,
        PSUBD,
        PSUBQ,
        PSUBSB,
        PSUBSIW,
        PSUBSW,
        PSUBUSB,
        PSUBUSW,
        PSUBW,
        PSWAPD,
        PTEST,
        PUNPCKHBW,
        PUNPCKHDQ,
        PUNPCKHQDQ,
        PUNPCKHWD,
        PUNPCKLBW,
        PUNPCKLDQ,
        PUNPCKLQDQ,
        PUNPCKLWD,
        PUSH,
        PUSHA,
        PUSHAD,
        PUSHAW,
        PUSHF,
        PUSHFD,
        PUSHFQ,
        PUSHFW,
        PXOR,
        RCL,
        RCPPS,
        RCPSS,
        RCR,
        RDM,
        RDMSR,
        RDPMC,
        RDSHR,
        RDTSC,
        RDTSCP,
        RESB,
        RESD,
        RESO,
        RESQ,
        REST,
        RESW,
        RESY,
        RET,
        RETF,
        RETN,
        ROL,
        ROR,
        ROUNDPD,
        ROUNDPS,
        ROUNDSD,
        ROUNDSS,
        RSDC,
        RSLDT,
        RSM,
        RSQRTPS,
        RSQRTSS,
        RSTS,
        SAHF,
        SAL,
        SALC,
        SAR,
        SBB,
        SCASB,
        SCASD,
        SCASQ,
        SCASW,
        SFENCE,
        SGDT,
        SHL,
        SHLD,
        SHR,
        SHRD,
        SHUFPD,
        SHUFPS,
        SIDT,
        SKINIT,
        SLDT,
        SMI,
        SMINT,
        SMINTOLD,
        SMSW,
        SQRTPD,
        SQRTPS,
        SQRTSD,
        SQRTSS,
        STC,
        STD,
        STGI,
        STI,
        STMXCSR,
        STOSB,
        STOSD,
        STOSQ,
        STOSW,
        STR,
        SUB,
        SUBPD,
        SUBPS,
        SUBSD,
        SUBSS,
        SVDC,
        SVLDT,
        SVTS,
        SWAPGS,
        SYSCALL,
        SYSENTER,
        SYSEXIT,
        SYSRET,
        TEST,
        UCOMISD,
        UCOMISS,
        UD0,
        UD1,
        UD2,
        UD2A,
        UD2B,
        UMOV,
        UNPCKHPD,
        UNPCKHPS,
        UNPCKLPD,
        UNPCKLPS,
        VADDPD,
        VADDPS,
        VADDSD,
        VADDSS,
        VADDSUBPD,
        VADDSUBPS,
        VAESDEC,
        VAESDECLAST,
        VAESENC,
        VAESENCLAST,
        VAESIMC,
        VAESKEYGENASSIST,
        VANDNPD,
        VANDNPS,
        VANDPD,
        VANDPS,
        VBLENDPD,
        VBLENDPS,
        VBLENDVPD,
        VBLENDVPS,
        VBROADCASTF128,
        VBROADCASTSD,
        VBROADCASTSS,
        VCMPEQPD,
        VCMPEQPS,
        VCMPEQSD,
        VCMPEQSS,
        VCMPEQ_OSPD,
        VCMPEQ_OSPS,
        VCMPEQ_OSSD,
        VCMPEQ_OSSS,
        VCMPEQ_UQPD,
        VCMPEQ_UQPS,
        VCMPEQ_UQSD,
        VCMPEQ_UQSS,
        VCMPEQ_USPD,
        VCMPEQ_USPS,
        VCMPEQ_USSD,
        VCMPEQ_USSS,
        VCMPFALSEPD,
        VCMPFALSEPS,
        VCMPFALSESD,
        VCMPFALSESS,
        VCMPFALSE_OSPD,
        VCMPFALSE_OSPS,
        VCMPFALSE_OSSD,
        VCMPFALSE_OSSS,
        VCMPGEPD,
        VCMPGEPS,
        VCMPGESD,
        VCMPGESS,
        VCMPGE_OQPD,
        VCMPGE_OQPS,
        VCMPGE_OQSD,
        VCMPGE_OQSS,
        VCMPGTPD,
        VCMPGTPS,
        VCMPGTSD,
        VCMPGTSS,
        VCMPGT_OQPD,
        VCMPGT_OQPS,
        VCMPGT_OQSD,
        VCMPGT_OQSS,
        VCMPLEPD,
        VCMPLEPS,
        VCMPLESD,
        VCMPLESS,
        VCMPLE_OQPD,
        VCMPLE_OQPS,
        VCMPLE_OQSD,
        VCMPLE_OQSS,
        VCMPLTPD,
        VCMPLTPS,
        VCMPLTSD,
        VCMPLTSS,
        VCMPLT_OQPD,
        VCMPLT_OQPS,
        VCMPLT_OQSD,
        VCMPLT_OQSS,
        VCMPNEQPD,
        VCMPNEQPS,
        VCMPNEQSD,
        VCMPNEQSS,
        VCMPNEQ_OQPD,
        VCMPNEQ_OQPS,
        VCMPNEQ_OQSD,
        VCMPNEQ_OQSS,
        VCMPNEQ_OSPD,
        VCMPNEQ_OSPS,
        VCMPNEQ_OSSD,
        VCMPNEQ_OSSS,
        VCMPNEQ_USPD,
        VCMPNEQ_USPS,
        VCMPNEQ_USSD,
        VCMPNEQ_USSS,
        VCMPNGEPD,
        VCMPNGEPS,
        VCMPNGESD,
        VCMPNGESS,
        VCMPNGE_UQPD,
        VCMPNGE_UQPS,
        VCMPNGE_UQSD,
        VCMPNGE_UQSS,
        VCMPNGTPD,
        VCMPNGTPS,
        VCMPNGTSD,
        VCMPNGTSS,
        VCMPNGT_UQPD,
        VCMPNGT_UQPS,
        VCMPNGT_UQSD,
        VCMPNGT_UQSS,
        VCMPNLEPD,
        VCMPNLEPS,
        VCMPNLESD,
        VCMPNLESS,
        VCMPNLE_UQPD,
        VCMPNLE_UQPS,
        VCMPNLE_UQSD,
        VCMPNLE_UQSS,
        VCMPNLTPD,
        VCMPNLTPS,
        VCMPNLTSD,
        VCMPNLTSS,
        VCMPNLT_UQPD,
        VCMPNLT_UQPS,
        VCMPNLT_UQSD,
        VCMPNLT_UQSS,
        VCMPORDPD,
        VCMPORDPS,
        VCMPORDSD,
        VCMPORDSS,
        VCMPORD_SPD,
        VCMPORD_SPS,
        VCMPORD_SSD,
        VCMPORD_SSS,
        VCMPPD,
        VCMPPS,
        VCMPSD,
        VCMPSS,
        VCMPTRUEPD,
        VCMPTRUEPS,
        VCMPTRUESD,
        VCMPTRUESS,
        VCMPTRUE_USPD,
        VCMPTRUE_USPS,
        VCMPTRUE_USSD,
        VCMPTRUE_USSS,
        VCMPUNORDPD,
        VCMPUNORDPS,
        VCMPUNORDSD,
        VCMPUNORDSS,
        VCMPUNORD_SPD,
        VCMPUNORD_SPS,
        VCMPUNORD_SSD,
        VCMPUNORD_SSS,
        VCOMISD,
        VCOMISS,
        VCVTDQ2PD,
        VCVTDQ2PS,
        VCVTPD2DQ,
        VCVTPD2PS,
        VCVTPH2PS,
        VCVTPS2DQ,
        VCVTPS2PD,
        VCVTPS2PH,
        VCVTSD2SI,
        VCVTSD2SS,
        VCVTSI2SD,
        VCVTSI2SS,
        VCVTSS2SD,
        VCVTSS2SI,
        VCVTTPD2DQ,
        VCVTTPS2DQ,
        VCVTTSD2SI,
        VCVTTSS2SI,
        VDIVPD,
        VDIVPS,
        VDIVSD,
        VDIVSS,
        VDPPD,
        VDPPS,
        VERR,
        VERW,
        VEXTRACTF128,
        VEXTRACTPS,
        VFMADD123PD,
        VFMADD123PS,
        VFMADD123SD,
        VFMADD123SS,
        VFMADD132PD,
        VFMADD132PS,
        VFMADD132SD,
        VFMADD132SS,
        VFMADD213PD,
        VFMADD213PS,
        VFMADD213SD,
        VFMADD213SS,
        VFMADD231PD,
        VFMADD231PS,
        VFMADD231SD,
        VFMADD231SS,
        VFMADD312PD,
        VFMADD312PS,
        VFMADD312SD,
        VFMADD312SS,
        VFMADD321PD,
        VFMADD321PS,
        VFMADD321SD,
        VFMADD321SS,
        VFMADDPD,
        VFMADDPS,
        VFMADDSD,
        VFMADDSS,
        VFMADDSUB123PD,
        VFMADDSUB123PS,
        VFMADDSUB132PD,
        VFMADDSUB132PS,
        VFMADDSUB213PD,
        VFMADDSUB213PS,
        VFMADDSUB231PD,
        VFMADDSUB231PS,
        VFMADDSUB312PD,
        VFMADDSUB312PS,
        VFMADDSUB321PD,
        VFMADDSUB321PS,
        VFMADDSUBPD,
        VFMADDSUBPS,
        VFMSUB123PD,
        VFMSUB123PS,
        VFMSUB123SD,
        VFMSUB123SS,
        VFMSUB132PD,
        VFMSUB132PS,
        VFMSUB132SD,
        VFMSUB132SS,
        VFMSUB213PD,
        VFMSUB213PS,
        VFMSUB213SD,
        VFMSUB213SS,
        VFMSUB231PD,
        VFMSUB231PS,
        VFMSUB231SD,
        VFMSUB231SS,
        VFMSUB312PD,
        VFMSUB312PS,
        VFMSUB312SD,
        VFMSUB312SS,
        VFMSUB321PD,
        VFMSUB321PS,
        VFMSUB321SD,
        VFMSUB321SS,
        VFMSUBADD123PD,
        VFMSUBADD123PS,
        VFMSUBADD132PD,
        VFMSUBADD132PS,
        VFMSUBADD213PD,
        VFMSUBADD213PS,
        VFMSUBADD231PD,
        VFMSUBADD231PS,
        VFMSUBADD312PD,
        VFMSUBADD312PS,
        VFMSUBADD321PD,
        VFMSUBADD321PS,
        VFMSUBADDPD,
        VFMSUBADDPS,
        VFMSUBPD,
        VFMSUBPS,
        VFMSUBSD,
        VFMSUBSS,
        VFNMADD123PD,
        VFNMADD123PS,
        VFNMADD123SD,
        VFNMADD123SS,
        VFNMADD132PD,
        VFNMADD132PS,
        VFNMADD132SD,
        VFNMADD132SS,
        VFNMADD213PD,
        VFNMADD213PS,
        VFNMADD213SD,
        VFNMADD213SS,
        VFNMADD231PD,
        VFNMADD231PS,
        VFNMADD231SD,
        VFNMADD231SS,
        VFNMADD312PD,
        VFNMADD312PS,
        VFNMADD312SD,
        VFNMADD312SS,
        VFNMADD321PD,
        VFNMADD321PS,
        VFNMADD321SD,
        VFNMADD321SS,
        VFNMADDPD,
        VFNMADDPS,
        VFNMADDSD,
        VFNMADDSS,
        VFNMSUB123PD,
        VFNMSUB123PS,
        VFNMSUB123SD,
        VFNMSUB123SS,
        VFNMSUB132PD,
        VFNMSUB132PS,
        VFNMSUB132SD,
        VFNMSUB132SS,
        VFNMSUB213PD,
        VFNMSUB213PS,
        VFNMSUB213SD,
        VFNMSUB213SS,
        VFNMSUB231PD,
        VFNMSUB231PS,
        VFNMSUB231SD,
        VFNMSUB231SS,
        VFNMSUB312PD,
        VFNMSUB312PS,
        VFNMSUB312SD,
        VFNMSUB312SS,
        VFNMSUB321PD,
        VFNMSUB321PS,
        VFNMSUB321SD,
        VFNMSUB321SS,
        VFNMSUBPD,
        VFNMSUBPS,
        VFNMSUBSD,
        VFNMSUBSS,
        VFRCZPD,
        VFRCZPS,
        VFRCZSD,
        VFRCZSS,
        VHADDPD,
        VHADDPS,
        VHSUBPD,
        VHSUBPS,
        VINSERTF128,
        VINSERTPS,
        VLDDQU,
        VLDMXCSR,
        VLDQQU,
        VMASKMOVDQU,
        VMASKMOVPD,
        VMASKMOVPS,
        VMAXPD,
        VMAXPS,
        VMAXSD,
        VMAXSS,
        VMCALL,
        VMCLEAR,
        VMINPD,
        VMINPS,
        VMINSD,
        VMINSS,
        VMLAUNCH,
        VMLOAD,
        VMMCALL,
        VMOVAPD,
        VMOVAPS,
        VMOVD,
        VMOVDDUP,
        VMOVDQA,
        VMOVDQU,
        VMOVHLPS,
        VMOVHPD,
        VMOVHPS,
        VMOVLHPS,
        VMOVLPD,
        VMOVLPS,
        VMOVMSKPD,
        VMOVMSKPS,
        VMOVNTDQ,
        VMOVNTDQA,
        VMOVNTPD,
        VMOVNTPS,
        VMOVNTQQ,
        VMOVQ,
        VMOVQQA,
        VMOVQQU,
        VMOVSD,
        VMOVSHDUP,
        VMOVSLDUP,
        VMOVSS,
        VMOVUPD,
        VMOVUPS,
        VMPSADBW,
        VMPTRLD,
        VMPTRST,
        VMREAD,
        VMRESUME,
        VMRUN,
        VMSAVE,
        VMULPD,
        VMULPS,
        VMULSD,
        VMULSS,
        VMWRITE,
        VMXOFF,
        VMXON,
        VORPD,
        VORPS,
        VPABSB,
        VPABSD,
        VPABSW,
        VPACKSSDW,
        VPACKSSWB,
        VPACKUSDW,
        VPACKUSWB,
        VPADDB,
        VPADDD,
        VPADDQ,
        VPADDSB,
        VPADDSW,
        VPADDUSB,
        VPADDUSW,
        VPADDW,
        VPALIGNR,
        VPAND,
        VPANDN,
        VPAVGB,
        VPAVGW,
        VPBLENDVB,
        VPBLENDW,
        VPCLMULHQHQDQ,
        VPCLMULHQLQDQ,
        VPCLMULLQHQDQ,
        VPCLMULLQLQDQ,
        VPCLMULQDQ,
        VPCMOV,
        VPCMPEQB,
        VPCMPEQD,
        VPCMPEQQ,
        VPCMPEQW,
        VPCMPESTRI,
        VPCMPESTRM,
        VPCMPGTB,
        VPCMPGTD,
        VPCMPGTQ,
        VPCMPGTW,
        VPCMPISTRI,
        VPCMPISTRM,
        VPCOMB,
        VPCOMD,
        VPCOMQ,
        VPCOMUB,
        VPCOMUD,
        VPCOMUQ,
        VPCOMUW,
        VPCOMW,
        VPERM2F128,
        VPERMIL2PD,
        VPERMIL2PS,
        VPERMILMO2PD,
        VPERMILMO2PS,
        VPERMILMZ2PD,
        VPERMILMZ2PS,
        VPERMILPD,
        VPERMILPS,
        VPERMILTD2PD,
        VPERMILTD2PS,
        VPEXTRB,
        VPEXTRD,
        VPEXTRQ,
        VPEXTRW,
        VPHADDBD,
        VPHADDBQ,
        VPHADDBW,
        VPHADDD,
        VPHADDDQ,
        VPHADDSW,
        VPHADDUBD,
        VPHADDUBQ,
        VPHADDUBWD,
        VPHADDUDQ,
        VPHADDUWD,
        VPHADDUWQ,
        VPHADDW,
        VPHADDWD,
        VPHADDWQ,
        VPHMINPOSUW,
        VPHSUBBW,
        VPHSUBD,
        VPHSUBDQ,
        VPHSUBSW,
        VPHSUBW,
        VPHSUBWD,
        VPINSRB,
        VPINSRD,
        VPINSRQ,
        VPINSRW,
        VPMACSDD,
        VPMACSDQH,
        VPMACSDQL,
        VPMACSSDD,
        VPMACSSDQH,
        VPMACSSDQL,
        VPMACSSWD,
        VPMACSSWW,
        VPMACSWD,
        VPMACSWW,
        VPMADCSSWD,
        VPMADCSWD,
        VPMADDUBSW,
        VPMADDWD,
        VPMAXSB,
        VPMAXSD,
        VPMAXSW,
        VPMAXUB,
        VPMAXUD,
        VPMAXUW,
        VPMINSB,
        VPMINSD,
        VPMINSW,
        VPMINUB,
        VPMINUD,
        VPMINUW,
        VPMOVMSKB,
        VPMOVSXBD,
        VPMOVSXBQ,
        VPMOVSXBW,
        VPMOVSXDQ,
        VPMOVSXWD,
        VPMOVSXWQ,
        VPMOVZXBD,
        VPMOVZXBQ,
        VPMOVZXBW,
        VPMOVZXDQ,
        VPMOVZXWD,
        VPMOVZXWQ,
        VPMULDQ,
        VPMULHRSW,
        VPMULHUW,
        VPMULHW,
        VPMULLD,
        VPMULLW,
        VPMULUDQ,
        VPOR,
        VPPERM,
        VPROTB,
        VPROTD,
        VPROTQ,
        VPROTW,
        VPSADBW,
        VPSHAB,
        VPSHAD,
        VPSHAQ,
        VPSHAW,
        VPSHLB,
        VPSHLD,
        VPSHLQ,
        VPSHLW,
        VPSHUFB,
        VPSHUFD,
        VPSHUFHW,
        VPSHUFLW,
        VPSIGNB,
        VPSIGND,
        VPSIGNW,
        VPSLLD,
        VPSLLDQ,
        VPSLLQ,
        VPSLLW,
        VPSRAD,
        VPSRAW,
        VPSRLD,
        VPSRLDQ,
        VPSRLQ,
        VPSRLW,
        VPSUBB,
        VPSUBD,
        VPSUBQ,
        VPSUBSB,
        VPSUBSW,
        VPSUBUSB,
        VPSUBUSW,
        VPSUBW,
        VPTEST,
        VPUNPCKHBW,
        VPUNPCKHDQ,
        VPUNPCKHQDQ,
        VPUNPCKHWD,
        VPUNPCKLBW,
        VPUNPCKLDQ,
        VPUNPCKLQDQ,
        VPUNPCKLWD,
        VPXOR,
        VRCPPS,
        VRCPSS,
        VROUNDPD,
        VROUNDPS,
        VROUNDSD,
        VROUNDSS,
        VRSQRTPS,
        VRSQRTSS,
        VSHUFPD,
        VSHUFPS,
        VSQRTPD,
        VSQRTPS,
        VSQRTSD,
        VSQRTSS,
        VSTMXCSR,
        VSUBPD,
        VSUBPS,
        VSUBSD,
        VSUBSS,
        VTESTPD,
        VTESTPS,
        VUCOMISD,
        VUCOMISS,
        VUNPCKHPD,
        VUNPCKHPS,
        VUNPCKLPD,
        VUNPCKLPS,
        VXORPD,
        VXORPS,
        VZEROALL,
        VZEROUPPER,
        WBINVD,
        WRMSR,
        WRSHR,
        XADD,
        XBTS,
        XCHG,
        XCRYPTCBC,
        XCRYPTCFB,
        XCRYPTCTR,
        XCRYPTECB,
        XCRYPTOFB,
        XGETBV,
        XLAT,
        XLATB,
        XOR,
        XORPD,
        XORPS,
        XRSTOR,
        XSAVE,
        XSETBV,
        XSHA1,
        XSHA256,
        XSTORE,
        CMOVcc,
        Jcc,
        SETcc,
    }
}
