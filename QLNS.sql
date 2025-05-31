create database QuanLyNhaSach
go
use QuanLyNhaSach

CREATE TABLE NXB
(
	MANXB INT CONSTRAINT NXB_MANXB_PR PRIMARY KEY IDENTITY (1,1),
	TENNXB NVARCHAR(100) CONSTRAINT NXB_TENNXB_NN NOT NULL,
	DIACHINAXB NVARCHAR(100) CONSTRAINT NXB_DIACHI_NN NOT NULL
)

CREATE TABLE TACGIA
(
	MATG INT CONSTRAINT TG_MATG_PK PRIMARY KEY IDENTITY (1,1),
	TENTG NVARCHAR(60) CONSTRAINT TG_TENTG_NN NOT NULL,
	GIOITINH NVARCHAR(4) CONSTRAINT TG_GT_NN NOT NULL,
	NOISINH NVARCHAR(80) CONSTRAINT TG_NS_NN NOT NULL,
	NAMSINH DATETIME
)

CREATE TABLE Sach
(
	MASACH INT CONSTRAINT S_MS_PK PRIMARY KEY IDENTITY (1,1),
	TENSACH NVARCHAR(80) CONSTRAINT S_TS_NN NOT NULL,
	MATG INT CONSTRAINT S_MATG_FK FOREIGN KEY (MATG) REFERENCES TACGIA(MATG),
	TENTL NVARCHAR(80) CONSTRAINT S_TTL_NN NOT NULL,
	GIASACH FLOAT CONSTRAINT S_GS_DF DEFAULT (100000),
	SLSACH INT CONSTRAINT S_SLSACH_NN NOT NULL,
	MANXB INT CONSTRAINT S_MANXB_FK FOREIGN KEY (MANXB) REFERENCES NXB(MANXB),
	TomTat NVARCHAR(MAX) CONSTRAINT S_TT_NN NOT NULL,
	HinhAnh VARBINARY(MAX) CONSTRAINT S_HA_NN NOT NULL
)

CREATE TABLE KHACHHANG
(
	MAKH INT CONSTRAINT KH_MAKH_PR PRIMARY KEY IDENTITY (1,1),
	TENKH NVARCHAR(100) CONSTRAINT KH_TENKH_NN NOT NULL,
	SDT VARCHAR(100) CONSTRAINT KH_SDT_NN NOT NULL,
	TenGmail VARCHAR(320) CONSTRAINT KH_TG_NN NOT NULL
)

CREATE TABLE DANGNHAP
(
	MAKH INT CONSTRAINT DN_MAKH_FK FOREIGN KEY(MAKH) REFERENCES KHACHHANG(MAKH),
	TENDN VARCHAR(100) CONSTRAINT DN_TENDN_NN NOT NULL,
	MATKHAU VARCHAR(80) CONSTRAINT DN_MK_NN NOT NULL,
	PRIMARY KEY(MAKH)
)

CREATE TABLE HOADON
(
	MAHD INT CONSTRAINT HD_MAHD_PK PRIMARY KEY IDENTITY(1,1),
	MAKH INT CONSTRAINT HD_MAKH_FK FOREIGN KEY(MAKH) REFERENCES KHACHHANG(MAKH),
	HinhThucTT NVARCHAR (100) CONSTRAINT HD_HTTT_CHECK CHECK (HinhThucTT IN(N'Chuyển tiền', N'Tiền mặt')),
	NgayHD DATETIME CONSTRAINT HD_NgayHD_NN NOT NULL,
	TongTien FLOAT CONSTRAINT HD_TT_NN NOT NULL,
	KenhMua VARCHAR(10) CONSTRAINT HD_KM_CHECK CHECK(KenhMua IN ('Online', 'Offline'))
)

CREATE TABLE ChiTietHoaDon
(
	MAHD INT CONSTRAINT CTHD_MAHD_FK FOREIGN KEY(MAHD) REFERENCES HOADON(MAHD),
	MaSach INT CONSTRAINT CTHD_MS_PR FOREIGN KEY(MASACH) REFERENCES SACH(MASACH),
	SLSach INT CONSTRAINT CTHD_SLSach_NN NOT NULL,
	TongGiaSach INT CONSTRAINT CTHD_TGSach_NN NOT NULL,
	PRIMARY KEY(MAHD, MASACH)
)

INSERT INTO NXB (TENNXB,DIACHINAXB) VALUES
( N'Nhà xuất bản Trẻ', N'161B Lý Chính Thắng, phường Võ Thị Sáu, Quận 3, TP. Hồ Chí Minh'),
( N'Nhà xuất bản Kim Đồng', N'248 Cống Quỳnh, P. Phạm Ngũ Lão, Q.1 TP. Hồ Chí Minh'),
(N'Nhà xuất bản Hội Nhà Văn', N'Số 65 Nguyễn Du, Quận Hai Bà Trưng, Hà Nội'),
(N'Nhà xuất bản Chính trị quốc gia Sự thật ', N'72 Trần Quốc Thảo, Phường Võ Thị Sáu, Quận 3, TP. HCM '),
(N'Nhà xuất bản Phụ nữ Việt Nam',N'16 Alexandre De Rhodes, Q.1, TP. HCM'),
(N'Nhà xuất bản Lao Động', N'175 Giảng Võ, Đống Đa, Hà Nội'),
(N'Nhà xuất bản Nhã Nam',N' 59 Đỗ Quang, Cầu Giấy, Hà Nội'),
(N'Nhà xuất bản Giáo dục', N'Số 81 Trần Hưng Đạo, Hoàn Kiếm, Hà Nội'),
(N'Nhà xuất bản Đại học Quốc gia thành phố Hồ Chí Minh', N'Phòng 501, Nhà Điều hành ĐHQG-HCM, phường Linh Trung, quận Thủ Đức, TP Hồ Chí Minh'),
(N'Nhà xuất bản Đại học Sư Phạm', N'Tầng 6, Toà nhà số 128 đường Xuân Thuỷ, phường Dịch Vọng Hậu, Quận Cầu Giấy, Thành phố Hà Nội')

INSERT INTO TACGIA(TENTG, GIOITINH, NOISINH, NAMSINH) VALUES
( N'Nguyễn Nhật Ánh', N'Nam',N'Tỉnh Quảng Nam', '1955'),
( N'Nguyễn Ngọc Tư', N'Nữ', N'Tỉnh Cà Mau', '1976'),
(N'Lý Qúi Trung', N'Nam', N'Sài Gòn', '1966'),
( N'Ii oka Jun ichi', N'Nam', N'Nhật Bản', '1945'),
( N'Fujiko Fujio', N'Nam', N'Nhật Bản', '1954'),
( N'Nguyễn Hổng Chiến', N'Nữ', N'Việt Nam', Null),
( N'Phương Trinh', N'Nữ', N'Việt Nam', null),
( N'Phan Đức Lộc', N'Nam', N'Đức Thành, Yên Thành, Nghệ An', '1995-12-24'),
( N'Antoine de Saint Exupéry', N'Nam', N'Pháp', '1900'),
( N'BS Nguyễn Lân Hiếu', N'Nam', N'Việt Nam',NULL),
( N'BONNI RUNYAN MCCULLOUGH - SUSAN WALKER MONSON', N'Nam','Anh', null),
( N'Trần Đăng Suyền', N'Nam',N'Việt Nam', null),
( N'Trần Trọng Dương', N'Nam', N'Việt Nam', null),
( N'Lê Thanh Ngân', N'Nữ', N'Việt Nam', null)

INSERT INTO SACH (TENSACH, MATG,TENTL,GIASACH, SLSACH, MANXB, TOMTAT, HINHANH) VALUES
(N'Tôi Thấy Hoa Vàng Trên Cỏ Xanh', 1, N'Truyện, Tiểu thuyết', 88000,20,1, N'Nội dung truyện nói vè tuổi thơ nghèo khó của hai anh em Thiều và Tường ở một làng quê Việt thân thuộc và nên thơ. Là nơi đã chứng kiến những rung động đầu đời của cả hai, tình cảm gia đình, tình anh em yêu thương chân thành, cũng như những đố kỵ, ghen tuông và những nỗi đau trong veo trong quá trình trưởng thành. Với những ký ức đã từng qua, chuyện về con cóc Cậu trời, chuyện ma, chuyện công chúa và hoàng tử, bên cạnh chuyện đói ăn, cháy nhà, lụt lội, tác giả muốn tưởng nhớ về tuổi thơ lắm ngọt ngào lẫn day dứt mà mỗi người đều đã từng trải qua khiến cho người đọc lại càng thấm đẫm tình yêu thương tuổi thơ của mình hơn.', (SELECT * FROM OPENROWSET (BULK N'D:\Final Winform Project\Picture\ToiThayHoaVangTrenCoXanh.png', SINGLE_BLOB) AS T1)),

(N'Trại Hoa Vàng', 1, N'Truyện, Tiểu thuyết', 90000,15,1, N'“Trại hoa vàng” là câu chuyện về cậu học trò tên Chuẩn. Bằng một phép màu kỳ diệu, trong cuộc chạy đua vào trường ” top” Trần Cao Vân, mặc dù là một học sinh được coi là ” bét bèn bẹt” ,nhưng Chuẩn không những đỗ vào trường điểm mà còn thừa số 0,5 điểm. Từ một đứa con vô tích sự,Chuẩn đã trở thành niềm tự hào của bố mẹ. Cùng với đó là quá trình ” cưa đổ “ mối tình đầu của Chuẩn với nàng Cẩm Phô. Cuốn truyện cũng xen lẫn nhiều chi tiết éo le, gây cười lớn cho bạn đọc. Một cậu bé trong ngày tựu trường phải mặc chiếc quần sửa từ quần của mẹ ở thắt lưng có tạo thành một hình mà chúng bạn cậu dí dỏm gọi là tam giác ” Béc – mu – đa”. Mặc dù, được che chắn rất cẩn thận nhưng Chuẩn vẫn bị hội nữ quái 10A2 chêu chọc.', (SELECT * FROM OPENROWSET (BULK N'D:\Final Winform Project\Picture\TraiHoaVang.png', SINGLE_BLOB) AS T2)),

(N'Bồ Câu Không Đưa Thư', 1, N'Truyện, Tiểu thuyết', 70000,19,1, N'Câu chuyện bắt đầu từ lá thư làm quen để trong học bàn của Thục, trong bộ ba Xuyến, Thục, Cúc Hương. Lá thư chân tình đã thu hút sự tò mò của bộ ba, và họ bị cuốn hút vào trò chơi với người giấu mặt, dần hồi kéo theo Phán củi, anh chàng xấu xí vụng về của lớp làm quân sư và giúp xướng họa thơ. Cuộc truy tìm dẫn mọi người đến nhiều hiểu lầm tai hại và cả những bất ngờ thú vị. Và điều bất ngờ cuốicùng đã được phát hiện quá muộn. Vì sao? Xin để cho bạn đọc tự khám phá.', (SELECT * FROM OPENROWSET (BULK N'D:\Final Winform Project\Picture\BoCauKhongDuaThu.png', SINGLE_BLOB) AS T3)),

(N'Cho Tôi Xin Một Vé Đi Tuổi Thơ', 1, N'Truyện, Tiểu thuyết', 100000,40, 1,N'Trên mạch kể hấp dẫn của câu chuyện, ngược dòng thời gian, tác giả đã đưa người đọc trở lại những năm tháng tuổi thơ vui vẻ với cốt truyện xoay quanh 4 bạn nhỏ nghịch ngợm, hồn nhiên cu Mùi, Hải cò, Tí sún và con Tủn. Trong thế giới tuổi thơ tươi đẹp ấy của những đứa trẻ, chúng không hề có những lo toan, bộn bề về cuộc sống vật chất và tinh thần mà chỉ hạnh phúc đắm chìm vào những trò chơi, những vui đùa của tuổi nhỏ. Trải dài trên từng trang viết là những câu chuyện hài hước, dí dỏm, những trò đùa vui vẻ khiến độc giả thực sự ước ao được quay lại những cảm xúc trong sáng, quãng thời gian vô tư như vậy một lần nữa. 
Đan xen vào những tình huống của 4 đứa trẻ, tác giả còn thêm vào cuốn sách cả những suy nghĩ, những chiêm nghiệm về cuộc sống hiện tại và quá khứ của con người khiến chúng ta phải dặn lòng suy ngẫm chúng.', (SELECT * FROM OPENROWSET (BULK N'D:\Final Winform Project\Picture\ChoTuiXinMotVeDiTuoiTho.png', SINGLE_BLOB) AS T4)),

(N'Sông', 2, N'Truyện, Tiểu Thuyết', 150000, 30, 1, N'Đây là tiểu thuyết đầu tay của nhà văn Nguyễn Ngọc Tư với sự đổi mới toàn diện của chính cô. Đẹp. Đáo để. Trần tục và hư ảo. Truyện kết thúc bằng dấu chấm hỏi về số phận một con người  - Không hề do dự, cô đã đẩy mầm ý tưởng vừa nhú lên sang tay người đọc, để họ nuôi dưỡng chúng, bằng trải nghiệm qua việc đọc cuốn sách này. 
"... Sài Gòn. Sáng nay ở đó Tú dậy, đánh răng rồi chở vợ ra đường, họ có thể cùng ăn sáng trước khi đến cơ quan. Sáng nay ở đó Hậu, Bách, Cường tiểu thơ vẫn còn nằm ngầy ngật trong hơi men vì nhậu nhẹt khuya. Sáng nay mẹ cậu mặc quần lửng, giày thể thao, đá cầu ở công viên xong thì xõa tóc ngồi quán cà phê với một trong những người đàn ông của bà, cũng có thể là cha cậu.
Sáng nay cậu cùng một người không thể gọi là lạ, cũng không thể nói đã quá biết nhau, đi xuyên qua những cánh rừng tinh linh đi tìm những khe suối nằm đâu đó giữa những vách đá. Hai thằng người bụi bặm và trông hơi tàn tạ…"', (SELECT * FROM OPENROWSET (BULK N'D:\Final Winform Project\Picture\Song.png', SINGLE_BLOB) AS T5)),


(N'Chỉ Có Niềm Đam Mê', 3, N'Truyện, Tiểu Thuyết', 80000, 30, 1, N'20 điều chia sẻ cùng người khởi nghiệp trong cuốn sách này chứa đựng nhiều điều hơn thế. Tác giả Lý Quí Trung, thành viên sáng lập Phở 24 và đang bắt đầu hành trình khởi nghiệp lần thứ hai với một tiệm ăn nhỏ trên phố Broadway của Sydney chia sẻ rằng "chỉ có niềm đam mê mới có thể giúp tôi vượt qua tất cả để bắt đầu lại từ đầu mà vẫn thấy hạnh phúc". Nhưng, đam mê thôi chưa đủ. Điều quan trọng tác giả muốn nói với các bạn trẻ khởi nghiệp: "Niềm đam mê dù có lớn đến đâu cũng không đủ để mở một nhà hàng thành công. Nó đòi hỏi nhiều điều khác nữa, mà trong đó kinh nghiệm và kiến thức là hai thứ tối thiểu".', (SELECT * FROM OPENROWSET (BULK N'D:\Final Winform Project\Picture\ChiCoNiemDamMe.png', SINGLE_BLOB) AS T6)),


(N'Connan', 4, N'Truyện tranh, thiếu nhi', 40000, 10, 2,N'Sera Masumi tiếp tục thăm dò Haibara Ai và ở thế đối đầu với Okiya Subaru! Trong khi đó, Conan đã tiến đến gần chân tướng của “em gái ngoài lãnh địa” - Mary…!? Haneda Shukichi bất ngờ gặp án mạng tại buổi học nhóm shogi! Vụ án diễn biến bất ngờ với nhiều khúc ngoặt để rồi cuối cùng, Akai Shuichi xuất hiện…!? Không dừng lại ở đó, tập 98 còn mang tới vụ án giải mật mã của một người giúp việc, nơi cuộc đua phá án giữa Conan và Heiji đã khởi phát từ mưu kế của Ooka Momiji!!',(SELECT * FROM OPENROWSET (BULK N'D:\Final Winform Project\Picture\Connan_98.png', SINGLE_BLOB) AS T7)),

(N'Doraemon', 5, N'Truyện tranh, thiếu nhi', 50000,20,2, N'Doraemon là nhân vật chính hư cấu trong loạt Manga cùng tên của họa sĩ Fujiko F. Fujio. Trong truyện lấy bối cảnh ở thế kỷ 22, Doraemon là chú mèo robot của tương lai do xưởng Matsushiba — công xưởng chuyên sản xuất robot vốn dĩ nhằm mục đích chăm sóc trẻ nhỏ', (SELECT * FROM OPENROWSET (BULK N'D:\Final Winform Project\Picture\Doraemon_1.png', SINGLE_BLOB) AS T8)),

(N'Chuồn chuồn ớt tìm mẹ',6, N'Truyện tranh, thiếu nhi', 60000, 10,2, N'Bộ áo giáp thân đốt mà Bọ mang theo trên mình từ thuở lọt lòng hình như đang nhẹ dần, nhẹ dần rồi vỡ ra. Từ trong hình hài một con Bọ Ăn Mày xấu xí, khi rũ bỏ bộ cánh cũ, bỗng hiện lên một thân hình hoàn toàn khác, màu đỏ tươi với đôi cánh mỏng tanh. Một cơn gió thoảng qua và có tiếng reo vang lên:  
           A,một con chuồn chuồn ớt.
Trích chuồn chuồn ớt tìm mẹ. 
Bọ ăn mày cồn mồ côi, quanh năm kiếm ăn nơi đáy ao, ẩn mình trên các câu rong và an phận với cuộc sống thường ngày. Từ khi nghe cô Ốc Nhồi kể về thế giới lạ lẫm phía trên mặt nước với trời cao, mây bay, gió thổi, Bọ ta quyết tâm lên đường thám hiểm bầu trời và tìm mẹ. Vừa lên khỏi mặt nước, nó lột xác trở thành chuồn chuồn với thân hình đỏ tươi như quả ớt chín. 
Vậy là hành trình tìm mẹ của Chuồn Chuồn Ớt bắt đầu. Mỗi thử thách là một bài học hấp dẫn cùng những câu chuyện kì thú về thế giới các loài sống trên mặt đất.', (SELECT * FROM OPENROWSET (BULK N'D:\Final Winform Project\Picture\ChuonChuonOtTimME.png', SINGLE_BLOB) AS T9)),

(N'Ngôi nhà tiếng cười', 7, N'Truyện tranh, thiếu nhi', 90000, 20, 2, N'Có một ngôi nhà nhỏ, nằm cuối con hẻm hẹp giữa lòng Sài Gòn như những đường gân trên chiếc lá xanh. Ngôi nhà ấy lạ lắm. Lạ vì tiếng cười lúc nào cũng vang lên. Lạ vì những đồ vật biết nói, và những thế giới bí ẩn luôn mời gọi',  (SELECT * FROM OPENROWSET (BULK N'D:\Final Winform Project\Picture\NgoiNhaTiengCuoi.png', SINGLE_BLOB) AS T10)),

(N'Tôi sẽ bay', 8, N'Truyện tranh, thiếu nhi', 70000, 30,2, N'Ai đi xa mà không nhớ những trò chơi thuở nhỏ, giữa ruộng vườn, đồi núi, đồng cỏ bồ công anh; nhớ những buổi chăn trâu rét cóng, đốt sưởi mói khoai nướng; những phiên chợ quê mộc mạc yên bình…?
Ai mà không có lúc đột nhiên thương mẹ thổn thức, tha thiết nhớ người thầy giáo cũ, thương đến xót xa bóng hình người bà giữa mùa hoa bưởi…? 
Và những hương vị canh lá lằng, cà muối mặn, khói đốt đồng… có làm bạn nao nao hoài niệm?', (SELECT * FROM OPENROWSET (BULK N'D:\Final Winform Project\Picture\ToiSeBay.png', SINGLE_BLOB) AS T11)),

( N'Hoàng Tử Bé', 9, N'Truyện tranh, thiếu nhi', 80000, 20, 2,N'Hoàng tử bé được xuất bản năm 1943, là tiểu thuyết nổi tiếng nhất của nhà văn và phi công Pháp Antoine de Saint-Exupéry. Ông đã thuê ngôi biệt thự The Bevin House ở Asharoken, Long Island, New York trong khi viết tác phẩm này. Cuốn tiểu thuyết cũng bao gồm nhiều bức tranh do chính Saint-Exupéry vẽ. Tác phẩm đã được dịch sang hơn 250 ngôn ngữ (bao gồm cả tiếng địa phương) và cho đến nay đã bán được hơn 200 triệu bản khắp thế giới, trở thành một trong những sách bán chạy nhất của mọi thời đại, được phát triển thành một sê ri truyện tranh 39 chương bởi Élyum Studio, và một phiên bản graphic novel bìa cứng chuyển thể bởi danh họa tài năng Joann Sfar. Truyện còn được dùng như tài liệu cho những người muốn làm quen với ngoại ngữ.',  (SELECT * FROM OPENROWSET (BULK N'D:\Final Winform Project\Picture\HoangTuBe.png', SINGLE_BLOB) AS T12)),

( N'Câu Chuyện Từ Trái Tim',10, N'Y tế', 90000,15,7, N'Bệnh viện - nơi mà cả bệnh nhân, người nhà bệnh nhân cũng như nhân viên y tế luôn phải đối mặt với những gì đau đớn nhất của thân phận con người - có rất ít chỗ cho sự giả dối. Những gì tử tế, cũng như những gì xấu xa, luôn hiển hiện lên một cách rõ nhất, chân thực nhất. Bác sĩ - người phải thường xuyên đưa ra quyết định ảnh hưởng trực tiếp đến cái sống, cái chết của bệnh nhân - luôn phải đối mặt với sự thật. Có lẽ đấy là một lý do mà trong những trang viết của BS. Lân Hiếu, người đọc cảm nhận được sức nặng của sự thật. Chuyển tải sự thật, ít nhất trong phạm vi nhận thức của mình, luôn là thử thách cam go nhất cho người viết',  (SELECT * FROM OPENROWSET (BULK N'D:\Final Winform Project\Picture\CauChuyenTuTraiTim.png', SINGLE_BLOB) AS T13)),

( N'Dạy con cách câu cá, đừng tặng cá cho con', 11,N'Truyện tranh, thiếu nhi', 100000, 12,6,  N'Khi con trẻ tới 18 tuổi thì chúng đã có 32.234 giờ được cha mẹ dạy dỗ. Cứ cho là thời gian chúng  ở trên lớp và nghiên cứu để hoàn thành chương trình cử nhân tại trường đại học thì cũng chỉ là 2.100 giờ và nếu con bạn đi học nghề thì chúng chỉ cần một nửa số  thời gian ấy thôi. Vậy là thời gian ở nhà của trẻ nhiều gấp mười sáu lần thời gian học tập ở trường đại học. Vậy các bậc cha mẹ muốn sử dụng lượng thời gian ấy như thế nào?
Hãy nghĩ đến việc đứa con của bạn khi trưởng thành sẽ ra đời và sống tự lập! Liệu chúng ta có chắc rằng chúng có thể tự giải quyết ổn thỏa những vấn đề trong cuộc sống (mà không cần cha mẹ)?', (SELECT * FROM OPENROWSET (BULK N'D:\Final Winform Project\Picture\DayConCachCauCa.png', SINGLE_BLOB) AS T14)),

( N'Phương pháp nghiên cứu tác phẩm văn học', 12, N'Ngữ Văn - Việt Nam học', 60000,10,10, N'Những tác phẩm văn học là những sự kiện văn học sử cốt yếu nhất, cơ bản nhất. Nghiên cứu văn học, dạy và học văn học thì không thể bỏ qua tác phẩm văn học. Trong quá trình nghiên cứu và giảng dạy văn học, từ lâu tôi dã có ý định viết một chuyên luận về nghiên cứu tác phẩm sao cho đưa được lí luận vào đời sống văn học, thiết thực với công việc giảng dạy và học văn học của giáo viên và học sinh. Tính chất hàn lâm không phải là đặc điểm của công trình này, như quan niệm của Albert Einstein: "Tất cả cần đưcọ biến thành đơn giản như có thể, nhưng không thể đơn giản hơn nữa"', (SELECT * FROM OPENROWSET (BULK N'D:\Final Winform Project\Picture\PhuongPhapNghienCuuTacPham.png', SINGLE_BLOB) AS T15)),

(N'Việt Nam thế kỷ X - Những mảnh vỡ lịch sử', 13, N'Tủ sách sử học', 90000, 6, 10, N'Cuốn sách Việt Nam thế kỉ X: Những mảnh vỡ lịch sử là tập hợp (có cập nhật, bổ sung) một số bài nghiên cứu mới hoặc đã được đăng ở một số tạp chí của TS. Trần Trọng Dương. Tác phẩm bao gồm "những mảnh vỡ lịch sử" gắn với các nhân vật, sự kiện và địa của "Việt Nam thế kỉ XX"', (SELECT * FROM OPENROWSET (BULK N'D:\Final Winform Project\Picture\VietNamTheKyX.png', SINGLE_BLOB) AS T16)),

INSERT INTO SACH (TENSACH, MATG,TENTL,GIASACH, SLSACH, MANXB, TOMTAT, HINHANH) VALUES
(N'Con lạnh lắm, mẹ có thể ôm con không?', 14,N'Nuôi dạy, giáo dục con cái', 20000, 10, 5, N'Cuốn sách này là tập hợp những bài viết về đề tài gia đình, tâm lý con trẻ ở góc nhìn của một người con có cha mẹ ly hôn, đồng thời cũng là tập hợp những dòng tự sự về nuôi dạy con cái trong vài năm hành trình làm mẹ của tôi',  (SELECT * FROM OPENROWSET (BULK N'D:\Final Winform Project\Picture\ConLanhLamMeCoTheOmConKhong.png', SINGLE_BLOB) AS T17))

DELETE FROM SACH
WHERE MASACH = 17;

INSERT INTO KHACHHANG ( TENKH, SDT, TENGMAIL) VALUES 
( N'Huỳnh Ngô Mỹ Vy', '0834290103', 'myvyhuynhngo@gmail.com'),
( N'Trần Tú Quyên', '09327643821', 'quyentran251@gmail.com'),
( N'Nguyễn Quế Trân', '0783261491', 'quetrannguyen@gmail.com'),
(N'Nguyễn Đăng Tâm Nguyên', '0917327368', 'bedeng@gmail.com'),
(N'Huỳnh Ngô Mỹ Kim', '0848311200', 'kimdollar@gmail.com'),
( N'Ngô Mỹ Tiên', '0844741222', 'ngomytien@gmail.com'),
( N'Nguyễn Thị Thu Hà', '0349349483', 'thuha@gmail.com'),
( N'Ngô Thị Yến Linh', '0353150395', 'yenlinhngo@gmail.com'),
(N'Phạm Thị Ánh Hồng', '0912463428', 'ashong@gmail.com'),
( N'Nguyễn Ngọc Trân', '0927358432', 'trannguyen483@gmail.com'),
(N'Thái Thị Kim Yến', '08509385092', 'ttkyen2003@gmail.com'),
( N'Nguyễn Ngọc Thanh Thanh', '09383907456', 'phungtn126@gmail.com'),
( N'Trần Hoàng Yến Nhi', '09834098245', 'ttkyen2003@gmail.com'),
(N'Lê Thị Vân Anh','0902485039','hoangchaungocphuong@gmail.com'),
(N'Huỳnh Quang Minh', '0819730819','huynhquangminh67@gmail.com')

INSERT INTO DANGNHAP (MAKH, TENDN, MATKHAU) VALUES 
(1, 'HuynhNgoMyVy', 'Vy291@'),
(2, 'TranTuQuyen','Quyen251@'),
(3,'NguyenQueTran', 'Tran123@'),
(4, 'NguyenDangTamNguyen','Nguyen033@'),
(5, 'HuynhNgoMyKim', 'Kim312@'),
(6,'NgoMyTien', 'Tien129@'),
(7, 'NguyenThiThuHa', 'Ha184@'),
(8, 'NgoThiYenLinh', 'Linh168@'),
(9, 'PhamThiAnhHong', 'Hong110@'),
(10, 'NguyenNgocTran', 'Tran451@'),
(11, 'ThaiThiKimYen', 'Yen800@'),
(12, 'NguyenNgocThanhThanh', 'Thanh137@'),
(13,'TranHoangYenNhi', 'Nhi839@'),
(14, 'LeThiVanAnh', 'Anh819@'),
(15,'HuynhQuangMinh', 'Minh191@')

INSERT INTO HoaDon (MAKH,HinhThucTT, NgayHD ,TongTien, KenhMua) VALUES
( 1,N'Tiền mặt', '2022-10-31' ,4460000, 'Offline'),
( 2, N'Chuyển tiền', '2022-10-31',70000, 'Online' ),
(  3, N'Tiền mặt','2022-10-30' ,300000, 'Online'),
( 4, N'Tiền mặt','2022-11-1',168000, 'Online'),
(  5, N'Chuyển tiền','2022-11-2',240000, 'Offline')

insert into ChiTietHoaDon(MAHD,MaSach, SLSach, TongGiaSach) VALUES
(1,1,2, 176000),
(2,2, 3,270000),
(2,3 , 1,70000),
(3, 4, 3, 300000),
(4, 1,1,88000),
(4, 7, 2, 80000),
(5, 2, 1,90000),
(5, 5, 1, 150000)

SELECT * FROM Sach
SELECT * FROM HoaDon
SELECT * FROM ChiTietHoaDon
SELECT * FROM KHACHHANG
SELECT * FROM NXB
SELECT * FROM DANGNHAP
SELECT * FROM TACGIA