package dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;

import dto.Book_VO;
import dto.Book_System_VO;

public class Book_DAO {
	private ArrayList<Book_VO> dtos;
	private Connection con;
	private Statement st;
	private PreparedStatement pstmt;
	private ResultSet rs;

	public Book_DAO() {
		dtos = new ArrayList<Book_VO>();

		try {
			String user = "system";
			String pw = "mj4660mp";
			String url = "jdbc:oracle:thin:@localhost:1521:XE";
			Class.forName("oracle.jdbc.driver.OracleDriver");
			con = DriverManager.getConnection(url, user, pw);
			st = con.createStatement();
		} catch (Exception e) {
			System.out.println("데이터베이스 연결 오류:" + e.getMessage());

		}

	}

	public ArrayList<Book_VO> getAllBook() {
		String SQL = "SELECT * FROM book";
		try {
			rs = st.executeQuery(SQL);
			while (rs.next()) {
				String NAME = rs.getString("NAME");
				String AUTHOR = rs.getString("AUTHOR");
				String PUBLISHER = rs.getString("PUBLISHER");
				int PUBLISHING_DATE = rs.getInt("PUBLISHING_DATE");
				String LIBRARY = rs.getString("LIBRARY");
				String REFERENCE_LIBRARY = rs.getString("REFERENCE_LIBRARY");
				String BOOK_SYMBOL = rs.getString("BOOK_SYMBOL");
				int KDC = rs.getInt("KDC");
				String LOAN = rs.getString("LOAN");

				Book_VO VO = new Book_VO(NAME, AUTHOR, PUBLISHER, PUBLISHING_DATE, LIBRARY, REFERENCE_LIBRARY,
						BOOK_SYMBOL, KDC, LOAN);
				dtos.add(VO);
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return dtos;
	}

	public ArrayList<Book_VO> DeleteBook(String NAME, String LIBRARY) {
		String SQL = "DELETE FROM book WHERE NAME=? AND LIBRARY=?";
		try {
			pstmt = con.prepareStatement(SQL);
			pstmt.setString(1, NAME);
			pstmt.setString(2, LIBRARY);
			pstmt.executeUpdate();
			System.out.println("삭제완료!");
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return dtos;
	}

	public ArrayList<Book_VO> InsertBook(String NAME, String AUTHOR, String PUBLISHER, int PUBLISHING_DATE,
			String LIBRARY, String REFERENCE_LIBRARY, String BOOK_SYMBOL, int KDC, String LOAN) {
		String SQL = "Insert INTO book(NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,"
				+ "REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) VALUES(?,?,?,?,?,?,?,?,?)";
		try {
			pstmt = con.prepareStatement(SQL);
			pstmt.setString(1, NAME);
			pstmt.setString(2, AUTHOR);
			pstmt.setString(3, PUBLISHER);
			pstmt.setInt(4, PUBLISHING_DATE);
			pstmt.setString(5, LIBRARY);
			pstmt.setString(6, REFERENCE_LIBRARY);
			pstmt.setString(7, BOOK_SYMBOL);
			pstmt.setInt(8, KDC);
			pstmt.setString(9, LOAN);
			pstmt.executeUpdate();
			System.out.println("추가완료!");
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return dtos;
	}

	public ArrayList<Book_VO> SearchNAME(String BookNAME) {
		String SQL = "SELECT * FROM book WHERE NAME LIKE '%" + BookNAME + "%'";
		try {
			pstmt = con.prepareStatement(SQL);
			rs = st.executeQuery(SQL);
			while (rs.next()) {
				String NAME = rs.getString("NAME");
				String AUTHOR = rs.getString("AUTHOR");
				String PUBLISHER = rs.getString("PUBLISHER");
				int PUBLISHING_DATE = rs.getInt("PUBLISHING_DATE");
				String LIBRARY = rs.getString("LIBRARY");
				String REFERENCE_LIBRARY = rs.getString("REFERENCE_LIBRARY");
				String BOOK_SYMBOL = rs.getString("BOOK_SYMBOL");
				int KDC = rs.getInt("KDC");
				String LOAN = rs.getString("LOAN");

				Book_VO VO = new Book_VO(NAME, AUTHOR, PUBLISHER, PUBLISHING_DATE, LIBRARY, REFERENCE_LIBRARY,
						BOOK_SYMBOL, KDC, LOAN);
				dtos.add(VO);
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return dtos;

	}

	public ArrayList<Book_VO> SearchLOAN() {
		String SQL = "SELECT * FROM book WHERE LOAN=" + "'" + "대출가능" + "'";
		try {
			
			rs = st.executeQuery(SQL);
			while (rs.next()) {
				String NAME = rs.getString("NAME");
				String AUTHOR = rs.getString("AUTHOR");
				String PUBLISHER = rs.getString("PUBLISHER");
				int PUBLISHING_DATE = rs.getInt("PUBLISHING_DATE");
				String LIBRARY = rs.getString("LIBRARY");
				String REFERENCE_LIBRARY = rs.getString("REFERENCE_LIBRARY");
				String BOOK_SYMBOL = rs.getString("BOOK_SYMBOL");
				int KDC = rs.getInt("KDC");
				String LOAN = rs.getString("LOAN");

				Book_VO VO = new Book_VO(NAME, AUTHOR, PUBLISHER, PUBLISHING_DATE, LIBRARY, REFERENCE_LIBRARY,
						BOOK_SYMBOL, KDC, LOAN);
				dtos.add(VO);
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return dtos;

	}

	public ArrayList<Book_VO> SearchLIBRARY(String library) {
		String SQL = "SELECT * FROM book WHERE LIBRARY LIKE '%" + library + "%'";
		try {
			pstmt = con.prepareStatement(SQL);
			rs = st.executeQuery(SQL);
			while (rs.next()) {
				String NAME = rs.getString("NAME");
				String AUTHOR = rs.getString("AUTHOR");
				String PUBLISHER = rs.getString("PUBLISHER");
				int PUBLISHING_DATE = rs.getInt("PUBLISHING_DATE");
				String LIBRARY = rs.getString("LIBRARY");
				String REFERENCE_LIBRARY = rs.getString("REFERENCE_LIBRARY");
				String BOOK_SYMBOL = rs.getString("BOOK_SYMBOL");
				int KDC = rs.getInt("KDC");
				String LOAN = rs.getString("LOAN");

				Book_VO VO = new Book_VO(NAME, AUTHOR, PUBLISHER, PUBLISHING_DATE, LIBRARY, REFERENCE_LIBRARY,
						BOOK_SYMBOL, KDC, LOAN);
				dtos.add(VO);
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return dtos;

	}

	public ArrayList<Book_VO> SearchREFERENCE_LIBRARY(String library, String reference_library) {
		String SQL = "select * from book where LIBRARY like '%'||?||'%'  and REFERENCE_LIBRARY like  '%'||?||'%' ";
		try {
			pstmt = con.prepareStatement(SQL);
			pstmt.setString(1, library);
			pstmt.setString(2, reference_library);
			rs = pstmt.executeQuery();
			while (rs.next()) {
				String NAME = rs.getString("NAME");
				String AUTHOR = rs.getString("AUTHOR");
				String PUBLISHER = rs.getString("PUBLISHER");
				int PUBLISHING_DATE = rs.getInt("PUBLISHING_DATE");
				String LIBRARY = rs.getString("LIBRARY");
				String REFERENCE_LIBRARY = rs.getString("REFERENCE_LIBRARY");
				String BOOK_SYMBOL = rs.getString("BOOK_SYMBOL");
				int KDC = rs.getInt("KDC");
				String LOAN = rs.getString("LOAN");

				Book_VO VO = new Book_VO(NAME, AUTHOR, PUBLISHER, PUBLISHING_DATE, LIBRARY, REFERENCE_LIBRARY,
						BOOK_SYMBOL, KDC, LOAN);
				dtos.add(VO);
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return dtos;
	}

	public ArrayList<Book_VO> UpdateLOAN(String NAME, String LIBRARY, String LOAN) {
		String SQL = "update book set LOAN=? where NAME=? AND LIBRARY like  '%'||?||'%'";
		try {
			pstmt = con.prepareStatement(SQL);
			pstmt.setString(1, LOAN);
			pstmt.setString(2, NAME);
			pstmt.setString(3, LIBRARY);
			pstmt.executeUpdate();
			System.out.print("수정완료!\n");
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return null;
	}
	
	public int loginCheck(String id,String pw) {
		try {
			String dbPW="";
			pstmt=con.prepareStatement
					("select pw from booksystem where id=?");
			pstmt.setString(1, id);
			rs=pstmt.executeQuery();
			
			if(rs.next()) {//아이디가 있을때,				
				dbPW=rs.getString("pw");//DB에서 가져온 패스워드
				if(dbPW.equals(pw)==true)//비밀번호일치
				{
					return 1;//아이디,비밀번호 둘다 일치
				}else {
					return 0;//비밀번호가 틀림
				}
			} else {			
				return -1;//아이디 없음
			}	
		}catch(Exception e) {
			e.printStackTrace();
		}
		return -1;
	}

}
