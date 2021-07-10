package org.rentacar;

import java.awt.EventQueue;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JTextArea;
import javax.swing.JScrollPane;

public class Interface {

	private JFrame frame;

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
		
		final JTextArea txtArea = new JTextArea();
		txtArea.setEditable(false);
		txtArea.setBounds(10, 131, 414, 119);
		frame.getContentPane().add(txtArea);
		
		JButton btnCars = new JButton("Find cars");
		btnCars.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				txtArea.setText("");
				WebServiceAssignment4SoapProxy proxy = new WebServiceAssignment4SoapProxy();
				
				try 
				{
					String [] stringArray = proxy.getAllCarsJava();
					for (int i = 0; i < stringArray.length; i++) {
						txtArea.append(stringArray[i] + "\n");
					}
				}
				catch (Exception ex) {}
				
				}
				
				}
		);
		btnCars.setBounds(22, 32, 110, 23);
		frame.getContentPane().add(btnCars);
		
		JButton btnPerson = new JButton("Find persons");
		btnPerson.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				WebServiceAssignment4SoapProxy proxy = new WebServiceAssignment4SoapProxy();
				txtArea.setText("");
				try 
				{
					String [] stringArray = proxy.getAllPersonsJava();
					for (int i = 0; i < stringArray.length; i++) {
						txtArea.append(stringArray[i] + "\n");
					}
				}
				catch (Exception ex) {}
			}
		});
		btnPerson.setBounds(142, 32, 124, 23);
		frame.getContentPane().add(btnPerson);
		
		JButton btnOwner = new JButton("Find owners");
		btnOwner.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				txtArea.setText("");
				WebServiceAssignment4SoapProxy proxy = new WebServiceAssignment4SoapProxy();
				
				try 
				{
					String [] stringArray = proxy.getAllOwnerJava();
					for (int i = 0; i < stringArray.length; i++) {
						txtArea.append(stringArray[i] + "\n");
					}
				}
				catch (Exception ex) {}
			}
		});
		btnOwner.setBounds(276, 32, 124, 23);
		frame.getContentPane().add(btnOwner);
		
		JScrollPane scrollPane = new JScrollPane(txtArea);
		scrollPane.setBounds(10, 131, 414, 119);
		frame.getContentPane().add(scrollPane);
	}
}
