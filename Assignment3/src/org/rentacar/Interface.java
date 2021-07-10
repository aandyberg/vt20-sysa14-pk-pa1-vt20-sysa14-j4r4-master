package org.rentacar;

import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.JButton;
import javax.swing.JTextArea;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class Interface {

	private JFrame frame;
	private JTextField textField_FileName;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Interface window = new Interface();
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
	public Interface() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 450, 300);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		JLabel lblFileName = new JLabel("File name:");
		lblFileName.setBounds(99, 34, 71, 14);
		frame.getContentPane().add(lblFileName);
		
		textField_FileName = new JTextField();
		textField_FileName.setBounds(180, 31, 148, 20);
		frame.getContentPane().add(textField_FileName);
		textField_FileName.setColumns(10);
		
		final JTextArea textArea_Contents = new JTextArea();
		textArea_Contents.setEditable(false);
		textArea_Contents.setBounds(10, 112, 414, 138);
		frame.getContentPane().add(textArea_Contents);
		
		JButton btnFind = new JButton("Show content");
		btnFind.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				textArea_Contents.setText("");
				String fileName = textField_FileName.getText();
				WebService3SoapProxy proxy = new WebService3SoapProxy();
				try {
				String content = proxy.rentacar(fileName);
				textArea_Contents.setText(content);
				}
				catch (java.rmi.RemoteException ex){
				}		
			}
		});
		btnFind.setBounds(180, 74, 121, 23);
		frame.getContentPane().add(btnFind);
	}
}
