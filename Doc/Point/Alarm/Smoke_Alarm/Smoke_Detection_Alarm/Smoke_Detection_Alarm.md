[Point](../../../Point.md) > [Alarm](../../Alarm.md) > [Smoke_Alarm](../Smoke_Alarm.md) > [Smoke_Detection_Alarm](.)
# Smoke_Detection_Alarm

**Display name:** Smoke Detection Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Smoke_Detection_Alarm;1

---


## Child interfaces
* [Discharge_Air_Smoke_Detection_Alarm](Discharge_Air_Smoke_Detection_Alarm.md)
* [Supply_Air_Smoke_Detection_Alarm](Supply_Air_Smoke_Detection_Alarm.md)

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
