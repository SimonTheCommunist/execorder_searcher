import json
import requests
import mysql.connector

#url="https://www.federalregister.gov/api/v1/documents.json?conditions%5Bcorrection%5D=0&conditions%5Bpresident%5D=donald-trump&conditions%5Bpresidential_document_type%5D=executive_order&conditions%5Btype%5D%5B%5D=PRESDOCU&fields%5B%5D=citation&fields%5B%5D=document_number&fields%5B%5D=end_page&fields%5B%5D=html_url&fields%5B%5D=pdf_url&fields%5B%5D=type&fields%5B%5D=subtype&fields%5B%5D=publication_date&fields%5B%5D=signing_date&fields%5B%5D=start_page&fields%5B%5D=title&fields%5B%5D=disposition_notes&fields%5B%5D=executive_order_number&fields%5B%5D=full_text_xml_url&fields%5B%5D=body_html_url&fields%5B%5D=json_url&order=executive_order&per_page=1000"
#Trump /|\
#url="https://www.federalregister.gov/api/v1/documents.json?conditions%5Bcorrection%5D=0&conditions%5Bpresident%5D=barack-obama&conditions%5Bpresidential_document_type%5D=executive_order&conditions%5Btype%5D%5B%5D=PRESDOCU&fields%5B%5D=citation&fields%5B%5D=document_number&fields%5B%5D=end_page&fields%5B%5D=html_url&fields%5B%5D=pdf_url&fields%5B%5D=type&fields%5B%5D=subtype&fields%5B%5D=publication_date&fields%5B%5D=signing_date&fields%5B%5D=start_page&fields%5B%5D=title&fields%5B%5D=disposition_notes&fields%5B%5D=executive_order_number&fields%5B%5D=full_text_xml_url&fields%5B%5D=body_html_url&fields%5B%5D=json_url&order=executive_order&per_page=1000"
#Obama /\
#url="https://www.federalregister.gov/api/v1/documents.json?conditions%5Bcorrection%5D=0&conditions%5Bpresident%5D=george-w-bush&conditions%5Bpresidential_document_type%5D=executive_order&conditions%5Btype%5D%5B%5D=PRESDOCU&fields%5B%5D=citation&fields%5B%5D=document_number&fields%5B%5D=end_page&fields%5B%5D=html_url&fields%5B%5D=pdf_url&fields%5B%5D=type&fields%5B%5D=subtype&fields%5B%5D=publication_date&fields%5B%5D=signing_date&fields%5B%5D=start_page&fields%5B%5D=title&fields%5B%5D=disposition_notes&fields%5B%5D=executive_order_number&fields%5B%5D=full_text_xml_url&fields%5B%5D=body_html_url&fields%5B%5D=json_url&order=executive_order&per_page=1000"
#Bush
#url="https://www.federalregister.gov/api/v1/documents.json?conditions%5Bcorrection%5D=0&conditions%5Bpresident%5D=william-j-clinton&conditions%5Bpresidential_document_type%5D=executive_order&conditions%5Btype%5D%5B%5D=PRESDOCU&fields%5B%5D=citation&fields%5B%5D=document_number&fields%5B%5D=end_page&fields%5B%5D=html_url&fields%5B%5D=pdf_url&fields%5B%5D=type&fields%5B%5D=subtype&fields%5B%5D=publication_date&fields%5B%5D=signing_date&fields%5B%5D=start_page&fields%5B%5D=title&fields%5B%5D=disposition_notes&fields%5B%5D=executive_order_number&fields%5B%5D=full_text_xml_url&fields%5B%5D=body_html_url&fields%5B%5D=json_url&order=executive_order&per_page=1000"
#clinton 
url="https://www.federalregister.gov/api/v1/documents.json?conditions%5Bcorrection%5D=0&conditions%5Bpresidential_document_type%5D=executive_order&conditions%5Btype%5D%5B%5D=PRESDOCU&fields%5B%5D=citation&fields%5B%5D=document_number&fields%5B%5D=end_page&fields%5B%5D=html_url&fields%5B%5D=pdf_url&fields%5B%5D=type&fields%5B%5D=subtype&fields%5B%5D=publication_date&fields%5B%5D=signing_date&fields%5B%5D=start_page&fields%5B%5D=title&fields%5B%5D=disposition_notes&fields%5B%5D=executive_order_number&fields%5B%5D=full_text_xml_url&fields%5B%5D=body_html_url&fields%5B%5D=json_url&order=executive_order&per_page=1000"
#all

mydb = mysql.connector.connect(
  host="localhost",
  user="redacted",
  password="redacted",
  database="execorders"
)
mycursor = mydb.cursor()

response = requests.get(url)
json_data = response.json()
count = json_data["count"]


for i in range (1, count):
    title = json_data["results"][i]["title"]
    date = json_data["results"][i]["signing_date"]
    pdf = json_data["results"][i]["pdf_url"]
    citenum = json_data["results"][i]["citation"]
    values = (title, date, pdf, citenum)
    sql = "INSERT INTO allOrd (title, date, pdf, citenum) VALUES (%s, %s, %s, %s)"

    mycursor.execute(sql, values)

    mydb.commit()

   
