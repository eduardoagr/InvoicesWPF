
using SQLite;

namespace Invoices.Model {
    public class User {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public override string ToString() {
            return $"{Name}";
        }
        public User() { }
    }
}
