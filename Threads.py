
class IObserver:
    def update(self, state):
        pass

class DashboardObserver(IObserver):
    def update(self, state):
        pass

class Thread:
    def _init_(self):
        self.Id = ""
        self.state = "created"
        self.priority = 0
        self.observerList = []
        self.notify()

    def notify(self):
        for observer in self.observers:
            observer.update(self.state)

    def start(self):
        self.state = "running"
        self.notify()

    def abort(self):
        self.state = "aborted"
        self.notify()

    def sleep(self, t):
        self.state = "sleeping"
        self.notify()
        self.sleep()
        self.state = "running"
        self.notify()

    def wait(self):
        self.state = "waiting"
        self.notify()

    def suspended(self):
        self.state = "suspended"
        self.notify()

    def subscribe(self, observer):
        self.observerList.append(observer)

    def unsubscribe(self, observer):
        if observer in self.observers:
            self.observerList.remove(observer)

if __name__ == "_main_":
    print("Hello zeiss")
    my_thread = Thread()
    dashboard_observer = DashboardObserver()

    my_thread.subscribe(dashboard_observer)
    my_thread.start()
    my_thread.sleep()
    my_thread.wait()
    my_thread.abort()

    my_thread.unsubscribe(dashboard_observer)
