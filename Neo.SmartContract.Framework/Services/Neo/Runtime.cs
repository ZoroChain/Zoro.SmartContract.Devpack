namespace Neo.SmartContract.Framework.Services.Neo
{
    public static class Runtime
    {
        public static extern TriggerType Trigger
        {
            [Syscall("Zoro.Runtime.GetTrigger")]
            get;
        }

        public static extern uint Time
        {
            [Syscall("Zoro.Runtime.GetTime")]
            get;
        }

        [Syscall("Zoro.Runtime.CheckWitness")]
        public static extern bool CheckWitness(byte[] hashOrPubkey);

        [Syscall("Zoro.Runtime.Notify")]
        public static extern void Notify(params object[] state);

        [Syscall("Zoro.Runtime.Log")]
        public static extern void Log(string message);
    }
}
