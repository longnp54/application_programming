import pandas, sys

#uri_exel_path = 'D:/Visual_Studio/application_programming/readexel_py/adidas.xlsx'
sys.stdout.reconfigure(encoding = 'utf-8')
excel_data_df = pandas.read_excel('adidas.xlsx', sheet_name='data')
#excel_data_df = pandas.read_excel(uri_exel_path, sheet_name='data')
json_str = excel_data_df.to_json(orient = 'records')
print(json_str)
