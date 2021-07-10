package org.rentacar;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JButton;
import javax.swing.JTextField;
import javax.swing.JLabel;
import javax.swing.JTextArea;
import java.awt.Color;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class Interface1 {

	private JFrame frame;
	private JTextField textFieldFN;
	private JTextField textFieldLN;
	private JTextField textFieldNO;
	private JTextField textFieldJT;
	private JTextField textFieldEM;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Interface1 window = new Interface1();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public Interface1() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.getContentPane().setBackground(Color.LIGHT_GRAY);
		frame.getContentPane().setForeground(Color.WHITE);
		frame.setBounds(100, 100, 614, 351);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		

		textFieldFN = new JTextField();
		textFieldFN.setBounds(83, 118, 86, 20);
		frame.getContentPane().add(textFieldFN);
		textFieldFN.setColumns(10);
		
		JLabel lblFirstName = new JLabel("First name");
		lblFirstName.setBounds(23, 121, 50, 14);
		frame.getContentPane().add(lblFirstName);
		
		textFieldLN = new JTextField();
		textFieldLN.setBounds(83, 161, 86, 20);
		frame.getContentPane().add(textFieldLN);
		textFieldLN.setColumns(10);
		
		JLabel lblLastName = new JLabel("Last name");
		lblLastName.setBounds(23, 164, 50, 14);
		frame.getContentPane().add(lblLastName);
		
		textFieldNO = new JTextField();
		textFieldNO.setBounds(83, 76, 86, 20);
		frame.getContentPane().add(textFieldNO);
		textFieldNO.setColumns(10);
		
		JLabel lblAddress = new JLabel("No.");
		lblAddress.setBounds(27, 79, 46, 14);
		frame.getContentPane().add(lblAddress);
		
		textFieldJT = new JTextField();
		textFieldJT.setBounds(83, 203, 86, 20);
		frame.getContentPane().add(textFieldJT);
		textFieldJT.setColumns(10);
		
		JLabel lblJobTitle = new JLabel("Job title");
		lblJobTitle.setBounds(27, 206, 46, 14);
		frame.getContentPane().add(lblJobTitle);
		
		textFieldEM = new JTextField();
		textFieldEM.setBounds(83, 246, 86, 20);
		frame.getContentPane().add(textFieldEM);
		textFieldEM.setColumns(10);
		
		JLabel lblNewLabel = new JLabel("Email");
		lblNewLabel.setBounds(27, 249, 46, 14);
		frame.getContentPane().add(lblNewLabel);
		
		final JTextArea textArea = new JTextArea();
		textArea.setEditable(false);
		textArea.setBounds(205, 159, 383, 142);
		frame.getContentPane().add(textArea);
		
		JButton btnAdd = new JButton("Add");
		btnAdd.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				WebServiceAss5SoapProxy proxy = new WebServiceAss5SoapProxy();
				String no = textFieldNO.getText();
				String firstName = textFieldFN.getText();
				String lastName = textFieldLN.getText();
				String jobTitle = textFieldJT.getText();
				String eMail = textFieldEM.getText();
				if (no.isEmpty()|| firstName.isEmpty() || lastName.isEmpty() || jobTitle.isEmpty() || eMail.isEmpty()) 
				{
					textArea.setText("Please fill in all the fields correctly");
				}
				else 
				{
					try 
					{
						
						String errorCheck = proxy.addEmployee(no, firstName, lastName, jobTitle, eMail);
						textArea.setText(errorCheck);
					}
					catch (java.rmi.RemoteException ex)
					{
					}
					
				}
			}
		});
		btnAdd.setBounds(10, 11, 89, 23);
		frame.getContentPane().add(btnAdd);
		
		JButton btnSearch = new JButton("Search");
		btnSearch.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				String no = textFieldNO.getText();
				Employee emp = new Employee();
				WebServiceAss5SoapProxy proxy = new WebServiceAss5SoapProxy();
				if (no.isEmpty()) 
				{
					textArea.setText("Fill in an employee number");
				}
				else 
				{
					try 
					{
						emp = proxy.searchEmployee(no);
						if (emp.getNo() == null) 
						{
							textArea.setText("No Employee found");
						}
						else 
						{
							textArea.setText("No: " + emp.getNo());
							textArea.append("\nFirst name: " + emp.getFirstName());
							textArea.append("\nLast name: " + emp.getLastName());
							textArea.append("\nJob Title: " + emp.getJobTitle());
							textArea.append("\nEmail: " + emp.getEMail());
						}
					}
					catch (java.rmi.RemoteException ex) 
					{
						
					}
				}
			}
		});
		btnSearch.setBounds(499, 11, 89, 23);
		frame.getContentPane().add(btnSearch);
		
		JButton btnUpdate = new JButton("Update");
		btnUpdate.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				WebServiceAss5SoapProxy proxy = new WebServiceAss5SoapProxy();
				String no = textFieldNO.getText();
				String firstName = textFieldFN.getText();
				String lastName = textFieldLN.getText();
				String jobTitle = textFieldJT.getText();
				String eMail = textFieldEM.getText();
				if (no.isEmpty()|| firstName.isEmpty() || lastName.isEmpty() || jobTitle.isEmpty() || eMail.isEmpty()) 
				{
					textArea.setText("Please fill in all the fields correctly");
				}
				else 
				{
					try 
					{
						
						String errorCheck = proxy.updateEmployee(no, firstName, lastName, jobTitle, eMail);
						textArea.setText(errorCheck);
					}
					catch (java.rmi.RemoteException ex)
					{
					}
					
				}
			}
		});
		btnUpdate.setBounds(132, 11, 89, 23);
		frame.getContentPane().add(btnUpdate);
		
		JButton btnDelete = new JButton("Delete");
		btnDelete.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				WebServiceAss5SoapProxy proxy = new WebServiceAss5SoapProxy();
				String no = textFieldNO.getText();
				try
				{
					String errorCheck = proxy.removeEmployee(no);
					textArea.setText(errorCheck);
				}
				catch (java.rmi.RemoteException ex) 
				{
				}
			}
		});
		btnDelete.setBounds(255, 11, 89, 23);
		frame.getContentPane().add(btnDelete);
	}
}
