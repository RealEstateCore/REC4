[Point](../../../../Point.md) > [Status](../../../Status.md) > [Pressure_Status](../../Pressure_Status.md) > [Differential_Pressure_Load_Shed_Status](../Differential_Pressure_Load_Shed_Status.md) > [Medium_Temperature_Hot_Water_Differential_Pressure_Load_Shed_Status](Medium_Temperature_Hot_Water_Differential_Pressure_Load_Shed_Status.md) > [Medium_Temperature_Hot_Water_Differential_Pressure_Load_Shed_Reset_Status](.)
# Medium_Temperature_Hot_Water_Differential_Pressure_Load_Shed_Reset_Status

**Display name:** Medium Temperature Hot Water Differential Pressure Load Shed Res<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Medium_Temperature_Hot_Water_Differential_Pressure_Load_Shed_Reset_Status;1

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|array (string)|False|
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
