package service;

import java.util.ArrayList;

import dao.Book_DAO;
import dto.Book_VO;



public class Book_Service {
	private Book_DAO dao;

	public Book_Service() {
		dao=new Book_DAO();

	}
	public ArrayList<Book_VO> getAllBook(){
		
		return dao.getAllBook();
	}
	
	public ArrayList<Book_VO>DeleteBook(String NAME,String LIBRARY){
		return dao.DeleteBook(NAME,LIBRARY);
	}
	public ArrayList<Book_VO> InsertBook(String NAME,String AUTHOR,String PUBLISHER,int PUBLISHING_DATE,
			String LIBRARY,String REFERENCE_LIBRARY,String BOOK_SYMBOL,int KDC,String LOAN){
		return dao.InsertBook(NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN);
	}
	public ArrayList<Book_VO>SearchNAME(String BookNAME){
		return dao.SearchNAME(BookNAME);
	}
	public ArrayList<Book_VO>SearchLOAN(){
		return dao.SearchLOAN();
	}
	public ArrayList<Book_VO>SearchLIBRARY(String library){
		return dao.SearchLIBRARY(library);
	}
	public ArrayList<Book_VO>SearchREFERENCE_LIBRARY(String library,String reference_library){
		return dao.SearchREFERENCE_LIBRARY(library,reference_library);
	}
	
	public ArrayList<Book_VO>UpdateLOAN(String NAME, String LIBRARY, String  LOAN){
		return dao.UpdateLOAN(NAME,LIBRARY,LOAN);
	}
	public int loginCheck(String id,String password) {
		return dao.loginCheck(id,password);
	}
}
