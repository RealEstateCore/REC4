[Point](../../Point.md) > [Sensor](../Sensor.md) > [Voltage_Sensor](#)
# Voltage_Sensor

**Display name:** Voltage Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Voltage_Sensor;1

---


## Child interfaces
* [Battery_Voltage_Sensor](Battery_Voltage_Sensor.md)
* [DC_Bus_Voltage_Sensor](DC_Bus_Voltage_Sensor.md)
* [Output_Voltage_Sensor](Output_Voltage_Sensor.md)

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
