import requests
from bs4 import BeautifulSoup

# Define URLs
login_page_url = 'http://crvs-institute.banbeis.gov.bd/institute-login'
login_check_url = 'http://crvs-institute.banbeis.gov.bd/institute-login-check'

# Create a session to manage cookies
session = requests.Session()

# Get the login page
login_page_response = session.get(login_page_url)
login_page_content = login_page_response.text

# Check for errors
if login_page_response.status_code != 200:
    print('Error:', login_page_response.status_code)
    exit()

# Parse the login page content
soup = BeautifulSoup(login_page_content, 'html.parser')

# Extract the CSRF token and crvs_session
xsrf_token = soup.find('input', {'name': '_token'})['value']

# Write XSRF-TOKEN to xsrf.txt
with open('xsrf.txt', 'w') as file:
    file.write(xsrf_token)

# Get crvs_session from cookies
crvs_session = session.cookies.get('crvs_session')

# Write crvs_session to crvs.txt
with open('crvs.txt', 'w') as file:
    file.write(crvs_session)

# Data to POST
post_data = {
    '_token': xsrf_token,
    'user': 'sksazan665@gmail.com',
    'password': 'Baba885@',
    'user_role': '2'
}

# Perform the login POST request
headers = {
    'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8',
    'X-Requested-With': 'XMLHttpRequest',
    'User-Agent': 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/125.0.6422.112 Safari/537.36',
    'Origin': 'http://crvs-institute.banbeis.gov.bd',
    'Referer': 'http://crvs-institute.banbeis.gov.bd/institute-login',
    'Accept': '*/*',
}

response = session.post(login_check_url, data=post_data, headers=headers)

# Check for errors
if response.status_code != 200:
    print('Error:', response.status_code)
else:
    print('Response:', response.text)
