namespace Neo.SmartContract.Framework.Services.Neo
{
    public class Header : IScriptContainer
    {
        public extern byte[] Hash
        {
            [Syscall("Zoro.Header.GetHash")]
            get;
        }

        public extern uint Version
        {
            [Syscall("Zoro.Header.GetVersion")]
            get;
        }

        public extern byte[] PrevHash
        {
            [Syscall("Zoro.Header.GetPrevHash")]
            get;
        }

        public extern byte[] MerkleRoot
        {
            [Syscall("Zoro.Header.GetMerkleRoot")]
            get;
        }

        public extern uint Timestamp
        {
            [Syscall("Zoro.Header.GetTimestamp")]
            get;
        }

        public extern uint Index
        {
            [Syscall("Zoro.Header.GetIndex")]
            get;
        }

        public extern ulong ConsensusData
        {
            [Syscall("Zoro.Header.GetConsensusData")]
            get;
        }

        public extern byte[] NextConsensus
        {
            [Syscall("Zoro.Header.GetNextConsensus")]
            get;
        }
    }
}
