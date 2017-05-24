#include <windows.h>
#include <iostream>
#include <stdio.h>
#include <process.h>
using namespace std;

const int n = 10;
int a[n];
HANDLE event;

DWORD WINAPI first(LPVOID)
{
	cout << "Thread 1 starts. ";

	for (int i = 0; i < n / 2; i++)
	{
		a[i] = 1;
	}
	cout << "Thread 1 finishes. ";

	SetEvent(event);
	return 0;
}
DWORD WINAPI second(LPVOID)
{
	cout << "Thread 2 waits. ";
	DWORD dwWaitResult;
	dwWaitResult = WaitForSingleObject(event, INFINITE);
	if (dwWaitResult == WAIT_OBJECT_0)
	{
		cout << "Thread 2 starts. ";
		for (int i = n / 2; i < n; i++)
		{
			a[i] = 2;
		}
	}
	cout << "Thread 2 finishes. ";
	return 0;
}
void print()
{
	for (int i = 0; i<n; i++)
	{
		cout << a[i];
	}
}
int main()
{
	HANDLE thread[2];
	event = CreateEvent(NULL, false, true, LPCWSTR("event"));
	thread[0] = CreateThread(0, 0, first, NULL, NULL, NULL);
	thread[1] = CreateThread(0, 0, second, NULL, NULL, NULL);
	WaitForMultipleObjects(2, thread, true, INFINITE);

	print();
	return 0;
}