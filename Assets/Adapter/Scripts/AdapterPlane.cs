namespace Adapter.Scripts
{
    public class AdapterPlane : IAcao
    {
        private Plane _plane;

        public AdapterPlane(Plane newPlane)
        {
            this._plane = newPlane;
        }

        public void Walk(string player)
        {
            this._plane.Fly("Bakudas");
        }

        public void Fire()
        {
            this._plane.FireMissile();
        }
    }
}