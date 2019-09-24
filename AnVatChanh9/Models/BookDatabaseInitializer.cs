using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;using System.Data.Entity;

namespace AnVatChanh9.Models
{
    public class BookDatabaseInitializer : DropCreateDatabaseAlways<BookContext>

    {
        protected override void Seed(BookContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetBooks().ForEach(p => context.Books.Add(p));
        }
        private static List<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Món hôm nay"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = " NGẮN HẠN"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "DÀI HẠN"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Đặt Hàng Nước Ngoài"
                }
            };
            return categories;
        }
        private static List<Book> GetBooks()
        {
            var books = new List<Book> {
                new Book
                {
                    BookID = 1,
                    BookName = "Chân gà xả tắc",
                    Description = "Vào những ngày hè nóng nực, một món ăn nhấm nháp cùng bạn bè ngay tại nhà sẽ là một sự lựa chọn rất tốt ",
                    ImagePath ="chan-ga-sả-tắc-recipe-main-photo.jpg",
                    UnitPrice = 16000f,
                    CategoryID = 1
                    },
                new Book
                {
                    BookID = 2,
                    BookName = "Sushi",
                    Description = "Nigiri sushi là loại sushi có nắm cơm trộn giấm hình bầu dục, được ép bằng tay, bên trên phủ một miếng cá sống hoặc hải sản tươi sống (cũng có thể chín) hay trứng chiên. Để làm được món ăn này bạn cần phải thật tỉ mỉ trong từng chi tiết nhỏ. Cơm phải nấu từ gạo Nhật với thời gian vừa đủ, trộn ngay với hỗn hợp giấm rồi để nguội. Các loại hải sản tươi được chọn lựa kỹ càng, bảo quản phù hợp và cắt thái đẹp mắt.",
                    ImagePath ="sushi.jpg",
                    UnitPrice = 50000f,
                    CategoryID = 1
                },
                new Book
                {
                    BookID = 3,
                    BookName = "Tuyết yến Dưỡng nhan",
                    Description = "Chè dưỡng nhan nhựa đào được người Vân Nam coi như “tổ yến bình dân“ vì chứa nhiều dưỡng chất, collagen thực vật, giúp da trở nên mịn màng , giảm vết nhăn trên cơ thể. các thành phần nấu chè còn có tác dụng thanh nhiệt, giải độc, tốt cho tiêu hoá. ",
                    ImagePath ="tuyetYen.jpg",
                    UnitPrice = 30500f,
                    CategoryID = 1
                },
                new Book
                {
                    BookID = 4,
                    BookName = "Cóc ngâm chua ngọt",
                    Description = "Món cóc ngâm đường chua ngọt giòn tan là khúc giao hòa giữa vị chua, ngọt và the cay cùng độ giòn của quả cóc nên được coi là món ăn vặt vô cùng quyến rũ và được rất nhiều người ưa chuộng.",
                    ImagePath ="cocNgam.jpg",
                    UnitPrice = 30000f,
                    CategoryID = 2
                },
                new Book
                {
                    BookID = 5,
                    BookName = "Su Kem",
                    Description = "Bánh su kem là món tráng miệng được rất nhiều người thích vì lớp vỏ bánh hơi dai, kết hợp hoàn hảo cùng nhân kem mát lạnh có vị ngọt nhẹ nhàng bên trong. ",
                    ImagePath ="su.jpg",
                    UnitPrice = 26500f,
                    CategoryID = 2
                },
                   new Book
                {
                    BookID = 7,
                    BookName = "Khô bò",
                    Description = "bò khô là món ăn khoái khẩu không thể thiếu của nhiều người nhất là các bạn trẻ. Khô bò có nhiều cách chế biến khác nhau cũng như mùi vị yêu thích của từng người. Nó kết hợp tạo ra những món ngon và thú vị gỏi khô bò, gỏi xoài ...  ",
                    ImagePath ="khobo.jpg",
                    UnitPrice = 150000f,
                    CategoryID = 3
                },
                   new Book
                   {
                       BookID =8,
                       BookName ="Khô gà lá chanh",
                       Description="Những miếng thịt gà khô ngon ngọt thơm lừng mùi lá chanh, vị dai dai, giòn giòn hòa quyện với vị cay cay nhè nhẹ của ớt khiến ai cũng phải xiêu lòng.",
                       ImagePath ="khoga.jpg",
                    UnitPrice = 120000f,
                    CategoryID = 3
                   },
                      new Book
                {
                    BookID = 9,
                    BookName = "Da Heo Mắm Tỏi Ớt",
                    Description = "Da heo chiên giòn lắc tỏi ớt nóng hổi, nhai trong miệng tạo cảm giác rôm rốp rất vui tai. Khi lắc cùng tỏi ớt mang đến hương vị cay cay, the the và thơm lừng của tỏi khiến bạn ăn mãi không thôi đấy. Và đây cũng là món ăn vặt luôn được giới trẻ yêu thích bất kể thời gian.  ",
                    ImagePath ="daheo.jpg",
                    UnitPrice = 26000f,
                    CategoryID = 3
                },
                    new Book
                {
                    BookID = 10,
                    BookName = "Bông lan Đài Loan",
                    Description = "bánh bông lan phô mai Đài Loan! Với sự xuất hiện khá cùng thời điểm của hai tiệm bánh là Le Castella và Tai Yang King Castella thì bánh bông lan đã trở thành một món bánh được nhiều người quyết tâm ăn thử khi đến phố đi bộ dù đôi khi phải xếp hàng chờ đợi khá lâu. ",
                    ImagePath ="bonglan.jpg",
                    UnitPrice = 17000f,
                    CategoryID = 4
                    },
                     new Book
                {
                    BookID = 11,
                    BookName = "Miến chua cay Trùng Khánh",
                    Description = "“Ngon” đó là cảm giác đầu tiên khi ăn thử món miến này. Vị chua vừa phải kết hợp cùng độ cay nồng kích thích vị giác làm dậy lên vị ngon đến lạ kỳ. ",
                    ImagePath ="mien.jpg",
                    UnitPrice = 80000f,
                    CategoryID = 4
                    },
                      new Book
                {
                    BookID = 12,
                    BookName = "Bim Bim",
                    Description = "Món ăn vặt gắn liền với bao thế hệ ",
                    ImagePath ="nc.png",
                    UnitPrice = 60500f,
                    CategoryID = 4
                    },
            };
            return books;
        }
    }
}