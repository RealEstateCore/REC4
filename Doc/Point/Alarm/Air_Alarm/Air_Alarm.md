[Point](../../Point.md) > [Alarm](../Alarm.md) > [Air_Alarm](#)
# Air_Alarm

**Display name:** Air Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Air_Alarm;1

---


## Child interfaces
* [Air_Flow_Alarm](Air_Flow_Alarm/Air_Flow_Alarm.md)
* [Air_Temperature_Alarm](../Temperature_Alarm/Air_Temperature_Alarm/Air_Temperature_Alarm.md)
* [Discharge_Air_Smoke_Detection_Alarm](../Smoke_Alarm/Smoke_Detection_Alarm/Discharge_Air_Smoke_Detection_Alarm.md)
* [Supply_Air_Smoke_Detection_Alarm](../Smoke_Alarm/Smoke_Detection_Alarm/Supply_Air_Smoke_Detection_Alarm.md)

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Point;1:** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name
## Target Of
### Inherited
* Asset.hasPoint
* EquipmentCollection.hasPoint
* ActuationEvent.targetPoint
* ExceptionEvent.sourcePoint
* ObservationEvent.sourcePoint
* ServiceObject.producedBy
* Architecture.hasPoint
