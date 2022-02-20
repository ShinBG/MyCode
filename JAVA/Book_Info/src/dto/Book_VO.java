package dto;

public class Book_VO {
	private String NAME;//책제목
	private String AUTHOR;//작가
	private String PUBLISHER;//출판사
	private int PUBLISHING_DATE;//출판년
	private String LIBRARY;//도서관
	private String REFERENCE_LIBRARY;//자료실
	private String BOOK_SYMBOL;//도서번호
	private int KDC;//kdc넘버
	private String LOAN;//대출중or대출가능
	
	

	public Book_VO(String NAME, String AUTHOR, String PUBLISHER, int PUBLISHING_DATE, String LIBRARY,
			String REFERENCE_LIBRARY, String BOOK_SYMBOL, int KDC, String LOAN) {
		
		this.NAME=NAME;
		this.AUTHOR=AUTHOR;
		this.PUBLISHER=PUBLISHER;
		this.PUBLISHING_DATE=PUBLISHING_DATE;
		this.LIBRARY=LIBRARY;
		this.REFERENCE_LIBRARY=REFERENCE_LIBRARY;
		this.BOOK_SYMBOL=BOOK_SYMBOL;
		this.KDC=KDC;
		this.LOAN=LOAN;	
	}
	public void setName(String NAME) {
		this.NAME=NAME;
	}
	public String getName() {
		return NAME;
	}
	public void setAuthor(String AUTHOR) {
		this.AUTHOR=AUTHOR;
	}
	public String getAuthor() {
		return AUTHOR;
	}
	public void setPublisher(String PUBLISHER) {
		this.PUBLISHER=PUBLISHER;
	}
	public String getPublisher() {
		return PUBLISHER;
	}
	public void setPublishing_Date(int PUBLISHING_DATE) {
		this.PUBLISHING_DATE=PUBLISHING_DATE;
	}
	public int getPublishing_Date() {
		return PUBLISHING_DATE;
	}
	public void setLibrary(String LIBRARY) {
		this.LIBRARY=LIBRARY;
	}
	public String getLibrary() {
		return LIBRARY;
	}
	public void setPeference_Library(String REFERENCE_LIBRARY) {
		this.REFERENCE_LIBRARY=REFERENCE_LIBRARY;
	}
	public String getPeference_Library() {
		return REFERENCE_LIBRARY;
	}
	public void setBook_Symbol(String BOOK_SYMBOL) {
		this.BOOK_SYMBOL=BOOK_SYMBOL;
	}
	public String getBook_Symbol() {
		return BOOK_SYMBOL;
	}
	public void setKdc(int KDC) {
		this.KDC=KDC;
	}
	public int getKdc() {
		return KDC;
	}
	public void setLoan(String LOAN) {
		this.LOAN=LOAN;
	}
	public String getLoan() {
		return LOAN;
	}
	
}
